namespace To_doListProject
{
    partial class Login
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(295, 55);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(175, 48);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Usuario";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_Username.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(202, 106);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(373, 52);
            this.textBox_Username.TabIndex = 1;
            this.textBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_Password.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(202, 249);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(373, 52);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Login
            // 
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Login.Location = new System.Drawing.Point(411, 346);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(164, 52);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Iniciar Sesion";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Register
            // 
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Register.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Register.Location = new System.Drawing.Point(202, 346);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(164, 52);
            this.button_Register.TabIndex = 5;
            this.button_Register.Text = "Registrar";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.UserLabel);
            this.Name = "Login";
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Register;
    }
}

