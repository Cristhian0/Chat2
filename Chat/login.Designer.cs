namespace Chat
{
	partial class login
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
			this.label2 = new System.Windows.Forms.Label();
			this.text_usuario = new System.Windows.Forms.TextBox();
			this.text_contrasena = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.State_Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "User";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// text_usuario
			// 
			this.text_usuario.Location = new System.Drawing.Point(89, 67);
			this.text_usuario.Name = "text_usuario";
			this.text_usuario.Size = new System.Drawing.Size(188, 20);
			this.text_usuario.TabIndex = 2;
			// 
			// text_contrasena
			// 
			this.text_contrasena.Location = new System.Drawing.Point(89, 115);
			this.text_contrasena.Name = "text_contrasena";
			this.text_contrasena.Size = new System.Drawing.Size(188, 20);
			this.text_contrasena.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(117, 167);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Sign in";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// State_Label
			// 
			this.State_Label.AutoSize = true;
			this.State_Label.Location = new System.Drawing.Point(13, 190);
			this.State_Label.Name = "State_Label";
			this.State_Label.Size = new System.Drawing.Size(35, 13);
			this.State_Label.TabIndex = 5;
			this.State_Label.Text = "label3";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 215);
			this.Controls.Add(this.State_Label);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.text_contrasena);
			this.Controls.Add(this.text_usuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox text_usuario;
		private System.Windows.Forms.TextBox text_contrasena;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label State_Label;
	}
}