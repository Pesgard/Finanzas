namespace To_doListProject
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radiobutton_Egreso = new System.Windows.Forms.RadioButton();
            this.radiobutton_Ingreso = new System.Windows.Forms.RadioButton();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(79, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(97, 114);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(153, 22);
            this.textBox_Cantidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // textbox_Descripcion
            // 
            this.textbox_Descripcion.Location = new System.Drawing.Point(294, 114);
            this.textbox_Descripcion.Multiline = true;
            this.textbox_Descripcion.Name = "textbox_Descripcion";
            this.textbox_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_Descripcion.Size = new System.Drawing.Size(210, 53);
            this.textbox_Descripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(287, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // groupBox
            // 
            this.groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.radiobutton_Egreso);
            this.groupBox.Controls.Add(this.radiobutton_Ingreso);
            this.groupBox.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox.Location = new System.Drawing.Point(74, 172);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(185, 132);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 18F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Concepto";
            // 
            // radiobutton_Egreso
            // 
            this.radiobutton_Egreso.AutoSize = true;
            this.radiobutton_Egreso.Font = new System.Drawing.Font("Roboto", 12F);
            this.radiobutton_Egreso.ForeColor = System.Drawing.Color.Transparent;
            this.radiobutton_Egreso.Location = new System.Drawing.Point(19, 94);
            this.radiobutton_Egreso.Name = "radiobutton_Egreso";
            this.radiobutton_Egreso.Size = new System.Drawing.Size(92, 28);
            this.radiobutton_Egreso.TabIndex = 1;
            this.radiobutton_Egreso.TabStop = true;
            this.radiobutton_Egreso.Text = "Egreso";
            this.radiobutton_Egreso.UseVisualStyleBackColor = true;
            // 
            // radiobutton_Ingreso
            // 
            this.radiobutton_Ingreso.AutoSize = true;
            this.radiobutton_Ingreso.Font = new System.Drawing.Font("Roboto", 12F);
            this.radiobutton_Ingreso.ForeColor = System.Drawing.Color.Transparent;
            this.radiobutton_Ingreso.Location = new System.Drawing.Point(19, 60);
            this.radiobutton_Ingreso.Name = "radiobutton_Ingreso";
            this.radiobutton_Ingreso.Size = new System.Drawing.Size(97, 28);
            this.radiobutton_Ingreso.TabIndex = 0;
            this.radiobutton_Ingreso.TabStop = true;
            this.radiobutton_Ingreso.Text = "Ingreso";
            this.radiobutton_Ingreso.UseVisualStyleBackColor = true;
            // 
            // button_Registrar
            // 
            this.button_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Registrar.ForeColor = System.Drawing.Color.Transparent;
            this.button_Registrar.Location = new System.Drawing.Point(318, 220);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(144, 40);
            this.button_Registrar.TabIndex = 6;
            this.button_Registrar.Text = "Registrar";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click_1);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(551, 394);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textbox_Descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radiobutton_Egreso;
        private System.Windows.Forms.RadioButton radiobutton_Ingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Registrar;
    }
}