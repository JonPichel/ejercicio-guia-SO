using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace cliente_temperatura
{
    public partial class Form1 : Form
    {

        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar")
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
                btnConectar.Text = "Desconectar";
            }
            else
            {
                string msg = "0/";
                byte[] msg_b = System.Text.Encoding.ASCII.GetBytes(msg);
                server.Send(msg_b);

                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
                btnConectar.Text = "Conectar";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rbnCelsius.Checked)
            {
                // Quiere saber la longitud
                string mensaje = "1/" + txtTemp.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }
            else
            {
                // Quiere saber la longitud
                string mensaje = "2/" + txtTemp.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }
        }
    }
}
