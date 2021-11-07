using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (btnConn.Text == "Conectarse")
            {
                IPAddress serv_addr = IPAddress.Parse("10.0.2.2");
                IPEndPoint ipep = new IPEndPoint(serv_addr, 4444);

                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);
                    this.BackColor = Color.Green;
                    MessageBox.Show("Conectado");
                }
                catch (SocketException exc)
                {
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
                btnConn.Text = "Desconectarse";
            }
            else
            {
                string msg = "0/";
                byte[] msg_b = System.Text.Encoding.ASCII.GetBytes(msg);
                server.Send(msg_b);

                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
                btnConn.Text = "Conectarse";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (rbnLongitud.Checked)
            {
                // Quiere saber la longitud
                string mensaje = "1/" + txtNombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("La longitud de tu nombre es: " + mensaje);
            }
            else if (rbnBonito.Checked)
            {
                // Quiere saber si el nombre es bonito
                string mensaje = "2/" + txtNombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                if (mensaje == "SI")
                    MessageBox.Show("Tu nombre ES bonito.");
                else
                    MessageBox.Show("Tu nombre NO bonito. Lo siento.");
            }
            else if (rbnAltura.Checked)
            {
                string mensaje = "3/" + txtNombre.Text + "/" + txtAltura.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }
            else if (rbnPalin.Checked)
            {
                string mensaje = "4/" + txtNombre.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                if (mensaje == "SI")
                {
                    MessageBox.Show("Tu nombre ES un palindromo");
                }
                else
                {
                    MessageBox.Show("Tu nombre NO es un palindromo");
                }
            }
            else
            {
                string mensaje = "5/" + txtNombre.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            string mensaje = "6/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            lblContador.Text = mensaje;
        }
    }
}
