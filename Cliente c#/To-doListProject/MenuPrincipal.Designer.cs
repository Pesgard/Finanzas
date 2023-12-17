namespace To_doListProject
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_inicio = new System.Windows.Forms.Button();
            this.button_Registro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.NavMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavMenu
            // 
            this.NavMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.NavMenu.Controls.Add(this.panel1);
            this.NavMenu.Controls.Add(this.button_inicio);
            this.NavMenu.Controls.Add(this.button_Registro);
            this.NavMenu.Controls.Add(this.button1);
            this.NavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavMenu.Location = new System.Drawing.Point(0, 0);
            this.NavMenu.Name = "NavMenu";
            this.NavMenu.Size = new System.Drawing.Size(213, 522);
            this.NavMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_inicio
            // 
            this.button_inicio.FlatAppearance.BorderSize = 0;
            this.button_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inicio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button_inicio.ForeColor = System.Drawing.Color.Transparent;
            this.button_inicio.Image = global::To_doListProject.Properties.Resources.icons8_home_25;
            this.button_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_inicio.Location = new System.Drawing.Point(3, 82);
            this.button_inicio.Name = "button_inicio";
            this.button_inicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_inicio.Size = new System.Drawing.Size(210, 62);
            this.button_inicio.TabIndex = 9;
            this.button_inicio.Text = "Inicio";
            this.button_inicio.UseVisualStyleBackColor = true;
            this.button_inicio.Click += new System.EventHandler(this.button_inicio_Click);
            // 
            // button_Registro
            // 
            this.button_Registro.FlatAppearance.BorderSize = 0;
            this.button_Registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Registro.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button_Registro.ForeColor = System.Drawing.Color.Transparent;
            this.button_Registro.Image = global::To_doListProject.Properties.Resources.icons8_add_25__1_;
            this.button_Registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Registro.Location = new System.Drawing.Point(3, 150);
            this.button_Registro.Name = "button_Registro";
            this.button_Registro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_Registro.Size = new System.Drawing.Size(210, 62);
            this.button_Registro.TabIndex = 7;
            this.button_Registro.Text = "Registro";
            this.button_Registro.UseVisualStyleBackColor = true;
            this.button_Registro.Click += new System.EventHandler(this.button_Registro_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::To_doListProject.Properties.Resources.icons8_list_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 218);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Historial";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PanelContenedor.BackgroundImage = global::To_doListProject.Properties.Resources.cash;
            this.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelContenedor.ForeColor = System.Drawing.Color.Transparent;
            this.PanelContenedor.Location = new System.Drawing.Point(219, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(777, 527);
            this.PanelContenedor.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(990, 522);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.NavMenu);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel NavMenu;
        private System.Windows.Forms.Button button_Registro;
        private System.Windows.Forms.Button button_inicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}