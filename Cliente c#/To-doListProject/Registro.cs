using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_doListProject
{
    public partial class Registro : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public Registro()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 5000); // Ajusta la dirección y el puerto según tu configuración
            stream = client.GetStream();
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

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar la conexión cuando se cierra el formulario
            stream.Close();
            client.Close();
        }

        private void button_Registrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar la entrada
                if (string.IsNullOrEmpty(textbox_Descripcion.Text) || !decimal.TryParse(textBox_Cantidad.Text, out decimal cantidad))
                {
                    MessageBox.Show("Por favor, ingrese una descripción válida y una cantidad numérica.");
                    return;
                }

                // Obtener la información del formulario
                string descripcion = textbox_Descripcion.Text;
                string tipoMovimiento = radiobutton_Ingreso.Checked ? "ingreso" : "gasto";

                // Construir el mensaje para enviar al servidor
                string message = $"{tipoMovimiento} {cantidad} {descripcion}";
                SendMessageToServer(message);

                // Recibir respuesta del servidor
                string response = ReceiveMessageFromServer();
                MessageBox.Show(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }}
}
