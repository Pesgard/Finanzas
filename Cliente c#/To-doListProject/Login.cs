using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace To_doListProject
{
    public partial class Login : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Login()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 5000); // Ajusta la dirección y el puerto según tu configuración
            stream = client.GetStream();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            // Enviar credenciales al servidor para el login
            string message = $"login {username} {password}";
            SendMessageToServer(message);

            // Recibir respuesta del servidor
            string response = ReceiveMessageFromServer();

            if (response == "Login exitoso")
            {
                // Abrir el formulario principal o realizar otras acciones después del inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión Exitoso.");
                Menu menuPrincipal = new Menu(client);
                this.Hide();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.");
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            // Enviar datos al servidor para el registro
            string message = $"registro {username} {password}";
            SendMessageToServer(message);

            // Recibir respuesta del servidor
            string response = ReceiveMessageFromServer();

            MessageBox.Show(response);
        }

        private void SendMessageToServer(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        private string ReceiveMessageFromServer()
        {
            byte[] data = new byte[1024];
            int bytesRead = stream.Read(data, 0, data.Length);
            return Encoding.UTF8.GetString(data, 0, bytesRead);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar la conexión cuando se cierra el formulario
            stream.Close();
            client.Close();
        }
    }
}
