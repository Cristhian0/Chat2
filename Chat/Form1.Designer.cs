namespace Chat
{
    partial class Form1
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
			this.btn_login = new System.Windows.Forms.Button();
			this.Btn_Configuracion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(12, 12);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(97, 33);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// Btn_Configuracion
			// 
			this.Btn_Configuracion.Location = new System.Drawing.Point(175, 12);
			this.Btn_Configuracion.Name = "Btn_Configuracion";
			this.Btn_Configuracion.Size = new System.Drawing.Size(104, 33);
			this.Btn_Configuracion.TabIndex = 1;
			this.Btn_Configuracion.Text = "Configuración";
			this.Btn_Configuracion.UseVisualStyleBackColor = true;
			this.Btn_Configuracion.Click += new System.EventHandler(this.Btn_Configuracion_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 74);
			this.Controls.Add(this.Btn_Configuracion);
			this.Controls.Add(this.btn_login);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Button Btn_Configuracion;
	}
}

