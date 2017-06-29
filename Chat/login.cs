using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Lync.Model;
using System.Threading;





namespace Chat
{
	public partial class login : Form
	{
		#region Variables
		LyncClient lyncClient;
		#endregion
		public login()
		{
			InitializeComponent();

			try
			{
				// Get the instance of Lync Client.
				lyncClient = LyncClient.GetClient();
				State_Label.Text = lyncClient.State.ToString();

				// Register the StateChanged event for Lync client.
				lyncClient.StateChanged += lyncClient_StateChanged;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:    " + ex.Message);
			}


		}

		void lyncClient_StateChanged(object sender, ClientStateChangedEventArgs e)
		{
			LabelUpdater(e.NewState.ToString());
		}

		/// <summary>
		/// Create a delegate for label control. This delegate is created because the Label element 
		/// is used in an another thread than the thread on which it has been created.
		/// </summary>
		/// <param name="newLabelValue"></param>
		private delegate void LabelUpdaterDelegate(string newLabelValue);

		/// <summary>
		/// Updates the label text to the current state of Lync client
		/// </summary>
		/// <param name="newLabelValue"></param>
		private void LabelUpdater(string newLabelValue)
		{
			if (State_Label.InvokeRequired)
			{
				LabelUpdaterDelegate labelDelegate = new LabelUpdaterDelegate(LabelUpdater);
				this.Invoke(labelDelegate, new object[] { newLabelValue });
			}
			else
			{
				State_Label.Text = newLabelValue;
			}

		}


		/// <summary>
		/// Click event handler for SignIn button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{

				// Check whether the user is signed out. If signed out then sign in the user on Lync 
				// else the user needs to first sign out of the Lync client and then run the application.
				if (lyncClient.State == ClientState.SignedOut)
				{
					if (!string.IsNullOrEmpty(text_usuario.Text) && !string.IsNullOrEmpty(text_contrasena.Text))
					{

						// If the valid credentials are provided then sign in the user on Lync.
						lyncClient.BeginSignIn(text_usuario.Text, text_usuario.Text, text_contrasena.Text, SignInCallback, null);

					}

					else
						MessageBox.Show("Enter username and password");

				}
				else
					MessageBox.Show("Sign out of the Lync first and then sign in using this Login form.");

			}

			// Displays the error message if any unknown exception or error is there.    
			catch (Exception ex) { MessageBox.Show("Error:    " + ex.Message); }

		}

		/// <summary>
		/// Handles callback for sign in to Lync.
		/// </summary>
		private void SignInCallback(IAsyncResult ar)
		{
			// Check that sign in to Lync is completed or not.
			if (ar.IsCompleted == true)
			{
				LabelUpdater(lyncClient.State.ToString());
				Thread.Sleep(2000);
				HideForm(this.FindForm());
			}

		}

		/// <summary>
		/// Create a delegate for form control. This delegate is created because the Form element 
		/// is used in an another thread than the thread on which it has been created.
		/// </summary>
		private delegate void formDelegate(Form form);

		/// <summary>
		/// Hides the form.
		/// </summary>
		private void HideForm(Form form)
		{
			if (form.InvokeRequired)
			{
				formDelegate fd = new formDelegate(HideForm);
				this.Invoke(fd, new object[] { form });
			}
			else
			{
				form.Hide();
			}
		}


		
	}
}
