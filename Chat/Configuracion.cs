﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Extensibility;

namespace Chat
{
	public partial class Configuracion : Form
	{
		LyncClient lyncClient;
		Automation automation;
		ContactManager contactMgr;
		List<SearchProviders> activeSearchProviders;
		ContactSubscription searchResultSubscription;

		public Configuracion()
		{
			InitializeComponent();

			try
			{


				//Obtener instancias de Lync Client y Contact Manager.
				lyncClient = LyncClient.GetClient();
				automation = LyncClient.GetAutomation();
				contactMgr = lyncClient.ContactManager;

				activeSearchProviders = new List<SearchProviders>();
				searchResultSubscription = contactMgr.CreateSubscription();

				// Carga Proveedor de búsqueda experto si está configurado y habilita la casilla de verificación.
				if (contactMgr.GetSearchProviderStatus(SearchProviders.Expert)
							  == SearchProviderStatusType.SyncSucceeded || contactMgr.GetSearchProviderStatus(SearchProviders.Expert)
							  == SearchProviderStatusType.SyncSucceededForExternalOnly || contactMgr.GetSearchProviderStatus(SearchProviders.Expert)
							  == SearchProviderStatusType.SyncSucceededForInternalOnly)
				{
					activeSearchProviders.Add(SearchProviders.Expert);

				}

				// Registrarse para el evento SearchProviderStatusChanged
				// by ContactManager.
				//contactMgr.SearchProviderStateChanged += contactMgr_SearchProviderStateChanged;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:    " + ex.Message);
			}
		}


		private System.Threading.Timer timer;
		public void SetUpTimer1(TimeSpan alertTime)
		{
			DateTime current = DateTime.Now;
			TimeSpan timeToGo = alertTime - current.TimeOfDay;
			if (timeToGo < TimeSpan.Zero)
			{
				return;//time already passed
			}
			this.timer = new System.Threading.Timer(x =>
			{
				this.EnviarMensajeBienvenida();
			}, null, timeToGo, Timeout.InfiniteTimeSpan);
		}

		public void SetUpTimer2(TimeSpan alertTime)
		{
			DateTime current = DateTime.Now;
			TimeSpan timeToGo = alertTime - current.TimeOfDay;
			if (timeToGo < TimeSpan.Zero)
			{
				return;//time already passed
			}
			this.timer = new System.Threading.Timer(x =>
			{
				this.EnviarMensajeDespedida();
			}, null, timeToGo, Timeout.InfiniteTimeSpan);
		}

		private void EnviarMensajeBienvenida()
		{
			List<string> inviteeList = new List<string>();

			inviteeList.Add("sip:alex.agudelo@accenture.com");



			// Create a generic Dictionary object to contain
			// conversation setting objects.
			Dictionary<AutomationModalitySettings, object> modalitySettings = new
				Dictionary<AutomationModalitySettings, object>();
			AutomationModalities chosenMode = AutomationModalities.InstantMessage;
			string firstIMMessageText = textBox1.Text;

			IAsyncResult ar = automation.BeginStartConversation(
		  chosenMode
		  , inviteeList
		  , modalitySettings
		  , null
		  , null);

			modalitySettings.Add(AutomationModalitySettings.FirstInstantMessage, firstIMMessageText);
			modalitySettings.Add(AutomationModalitySettings.SendFirstInstantMessageImmediately,
				true);
			IAsyncResult er = automation.BeginStartConversation(
		  chosenMode
		  , inviteeList
		  , modalitySettings
		  , null
		  , null);
		}

		private void EnviarMensajeDespedida()
		{
			List<string> inviteeList = new List<string>();

			inviteeList.Add("sip:alex.agudelo@accenture.com");



			// Create a generic Dictionary object to contain
			// conversation setting objects.
			Dictionary<AutomationModalitySettings, object> modalitySettings = new
				Dictionary<AutomationModalitySettings, object>();
			AutomationModalities chosenMode = AutomationModalities.InstantMessage;
			string firstIMMessageText = textBox1.Text;

			IAsyncResult ar = automation.BeginStartConversation(
		  chosenMode
		  , inviteeList
		  , modalitySettings
		  , null
		  , null);

			modalitySettings.Add(AutomationModalitySettings.FirstInstantMessage, firstIMMessageText);
			modalitySettings.Add(AutomationModalitySettings.SendFirstInstantMessageImmediately,
				true);
			IAsyncResult er = automation.BeginStartConversation(
		  chosenMode
		  , inviteeList
		  , modalitySettings
		  , null
		  , null);
		}


		private void button1_Click(object sender, EventArgs e)
		{

			



		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
