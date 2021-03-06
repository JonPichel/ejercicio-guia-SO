#include <string.h>
#include <ctype.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

void *atender_cliente(void *socket);

int contador = 0;
pthread_mutex_t mutex_contador = PTHREAD_MUTEX_INITIALIZER;

int nsockets, sockets[100];

int main(int argc, char *argv[])
{
	int sock_listen, sock_conn;
	struct sockaddr_in host_addr;
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
	
    pthread_t threads[100];
	for(nsockets = 0; nsockets < 10; i++) {
		printf("Escuchando\n");
		
        // Los argumentos 2 y 3 se usan si queremos conocer la direccion del cliente
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido conexion\n");

        sockets[nsockets] = sock_conn;
        pthread_create(&threads[nsockets], NULL, atender_cliente, &sock_conn);
	}
    for (; nsockets > 0; nsockets--) {
        pthread_join(threads[nsockets], NULL);
    }
}

void *atender_cliente(void *socket) {
	char peticion[512], respuesta[512];
    char notificacion[20];
    int sock_conn = *(int *)socket;
    char *p, nombre[20];
    int codigo, nbytes;
    while (1) {
        // Ahora recibimos su nombre, que dejamos en el buffer
        nbytes = read(sock_conn, peticion, sizeof(peticion));
        peticion[nbytes] = '\0';
        printf("Peticion: %s\n", peticion);

        // Procesamos la peticion
        p = strtok(peticion, "/");
        codigo = atoi(p);
        if ((p = strtok(NULL, "/")) == NULL) {
            strcpy(nombre, "");
        } else {
            strcpy(nombre, p);
        }
        printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
        
        if (codigo == 0) {
            break;
        }

        // Generamos la respuesta
        int i, j, palindromo;
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
            case 4:
                // Servicio de palindromo
                i = 0;
                j = strlen(nombre) - 1;
                while (1) {
                    if (toupper(nombre[i++]) != toupper(nombre[j--])) {
                        sprintf(respuesta, "NO");
                        break;
                    }
                    if (i >= j) {
                        sprintf(respuesta, "SI");
                        break;
                    }
                }
                break;
            case 5:
                // Servicio de nombre en mayusculas
                p = nombre;
                while (*p != '\0') {
                    *p = toupper(*p);
                    p++;
                }
                strcpy(respuesta, nombre);
                break;
            default:
                printf("Codigo desconocido: %d\n", codigo);
                close(sock_conn);
                return NULL;
        }

        // Enviamos la respuesta
        printf("Respuesta: %s\n", respuesta);
        write(sock_conn, respuesta, strlen(respuesta));

        pthread_mutex_lock(&mutex_contador);
        contador++;
        pthread_mutex_unlock(&mutex_contador);
        sprintf(notificacion, "%d", contador);
        for (int j = 0; j < nsockets; j++) {
            write(sockets[j], notificacion, strlen(notificacion));
        }
    }
    
    // Cerramos el socket file descriptor
    close(sock_conn); 
}
