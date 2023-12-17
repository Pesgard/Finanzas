using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace To_doListProject
{
    public partial class Menu: Form
    {
        private TcpClient client;

        public Menu(TcpClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirForminPanel(object childrenForm)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form cf = childrenForm as Form;
            cf.TopLevel = false;
            cf.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(cf);
            this.PanelContenedor.Tag = cf;
            cf.Show();
        }

        private void button_inicio_Click(object sender, EventArgs e)
        {
            // Ejemplo de abrir el formulario de Inicio en el panel
            AbrirForminPanel(new Inicio());
        }

        private void button_Registro_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Registro());
        }
    }
}
