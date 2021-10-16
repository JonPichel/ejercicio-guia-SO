#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
	int sock_listen, sock_conn, nbytes;
	struct sockaddr_in host_addr;
	char peticion[512], respuesta[512];
    int puerto; 

    if (argc > 1) {
        puerto = atoi(argv[1]);
    } else {
        puerto = 4444;
    }

	// Abrimos el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
		printf("Error creando el socket");
        return -1;
    }

	memset(&host_addr, 0, sizeof(host_addr));

	host_addr.sin_family = AF_INET;
    // Asocia el socket a cualquier IP de la maquina
	host_addr.sin_addr.s_addr = htonl(INADDR_ANY);
	host_addr.sin_port = htons(puerto);

    // Hacemos bind al socket
	if (bind(sock_listen, (struct sockaddr *)&host_addr, sizeof(host_addr)) < 0) {
		printf("Error en el bind");
        return -1;
    }

	// Maximo 2 conexiones en la cola de espera
	if (listen(sock_listen, 2) < 0) {
		printf("Error en el listen");
        return -1;
    }
	
	for(;;) {
		printf("Escuchando\n");
		
        // Los argumentos 2 y 3 se usan si queremos conocer la direccion del cliente
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido conexion\n");
		
		
        while (1) {
            // Ahora recibimos su nombre, que dejamos en el buffer
            nbytes = read(sock_conn, peticion, sizeof(peticion));
            peticion[nbytes] = '\0';
            printf("Peticion: %s\n", peticion);

            // Procesamos la peticion
            char *p, nombre[20];
            int codigo;
            p = strtok(peticion, "/");
            codigo = atoi(p);
            if ((p = strtok(NULL, "/")) == NULL) {
                printf("Error en la peticion: nombre vacio\n");
                strcpy(nombre, "");
            } else {
                strcpy(nombre, p);
            }
            printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
            
            if (codigo == 0) {
                break;
            }

            // Generamos la respuesta
            switch (codigo) {
                case 1:
                    // Servicio de longitud de nombre
                    sprintf(respuesta, "%d", strlen(nombre));
                    break;
                case 2:
                    // Servicio de valoracion de nombre
                    if (nombre[0] == 'M' || nombre[0] == 'S') {
                        strcpy(respuesta, "SI");
                    } else {
                        strcpy(respuesta, "NO");
                    }
                    break;
                case 3:
                    // Servicio de valoracion de altura
                    p = strtok(NULL, "/");
                    float altura = atof(p);
                    if (altura > 1.70)
                        sprintf(respuesta, "%s: eres alto", nombre);
                    else
                        sprintf(respuesta, "%s: eres bajo", nombre);
                    break;
                default:
                    printf("Codigo desconocido: %d\n", codigo);
                    close(sock_conn);
                    return -1;
            }

            // Enviamos la respuesta
            printf("Respuesta: %s\n", respuesta);
            write(sock_conn, respuesta, strlen(respuesta));
        }
        
        // Cerramos el socket file descriptor
        close(sock_conn); 
	}
}
