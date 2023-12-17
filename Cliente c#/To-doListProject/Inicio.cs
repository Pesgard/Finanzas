using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;
//using Newtonsoft.Json;


namespace To_doListProject
{
    public partial class Inicio : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Inicio()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 5000); // Ajusta la dirección y el puerto según tu configuración
            stream = client.GetStream();
            ActualizarTotalBalance();  // Actualizar el balance al cargar el formulario
           /*
            String api_key = "623b2ac925b9f4f89c44b66081945fba";
            String city = "Los mochis";
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={api_key}&units=metric";
            WebRequest request =WebRequest.Create(URL);
            HttpWebResponse httpWebResponse = null;
            httpWebResponse= (HttpWebResponse)request.GetResponse();
            String resultado = string.Empty;

            using (Stream stream = httpWebResponse.GetResponseStream()) ;
           */


        }

        // Método para actualizar el labelTotalCuenta con el total del balance
        private void ActualizarTotalBalance()
        {
            // Enviar comando al servidor para obtener el balance
            string message = "balance";
            SendMessageToServer(message);

            // Recibir respuesta del servidor
            string response = ReceiveMessageFromServer();
            label1.Text = response;  // Suponiendo que el servidor envía el balance como texto
        }

        // Método para enviar mensajes al servidor
        private void SendMessageToServer(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        // Método para recibir mensajes del servidor
        private string ReceiveMessageFromServer()
        {
            byte[] data = new byte[1024];
            int bytesRead = stream.Read(data, 0, data.Length);
            return Encoding.UTF8.GetString(data, 0, bytesRead);
        }

        // Evento de botón para recargar el balance
        private void btnRecargarBalance_Click(object sender, EventArgs e)
        {
            ActualizarTotalBalance();
        }

        // Otros eventos y métodos en tu formulario...
    }
}
