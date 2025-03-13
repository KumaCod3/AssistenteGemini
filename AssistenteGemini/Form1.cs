using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AssistenteGemini
{
	public partial class Form1: Form
	{
		private int selezionato = -1;
		private List<RadioButton> radioBB = new List<RadioButton>();
		public Form1()
		{
			InitializeComponent();
			string oldPrompt = GeminiAssistant.promptMod;
			this.textBox1.Text = oldPrompt;
			System.Drawing.Point loc = new System.Drawing.Point(358, 20);

			foreach (string pr in GeminiAssistant.prompts)
			{
				RadioButton radioButton = new RadioButton();
				this.Controls.Add(radioButton);
				radioButton.Text = pr;
				radioButton.Location = loc;
				radioButton.Size = new System.Drawing.Size(350, 40);
				radioButton.AutoSize = false;
				radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				loc.Y = loc.Y + 40;
				radioBB.Add(radioButton);
			}

		}

		private void modProm_Click(object sender, System.EventArgs e)
		{
			string x = "";
			x = this.textBox1.Text;
			GeminiAssistant.aggiungiPrompt(x);
			GeminiAssistant.bakupPrompt();
			this.Close();
		}

		private void selez_Click(object sender, System.EventArgs e)
		{
			if (selezionato != -1)
			{
				GeminiAssistant.promptMod = GeminiAssistant.prompts[selezionato];
				this.Close();
			}
		}

		private void elim_Click(object sender, System.EventArgs e)
		{
			if (selezionato != -1)
			{
				GeminiAssistant.prompts.RemoveAt(selezionato);
				Form1 mod = new Form1();
				mod.Visible = true;
				mod.Activate();
				this.Close();
				GeminiAssistant.bakupPrompt();
			}
		}

		void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;

			if (rb == null)
			{
				MessageBox.Show("Sender is not a RadioButton");
				return;
			}

			// Ensure that the RadioButton.Checked property
			// changed to true.
			if (rb.Checked)
			{
				// Keep track of the selected RadioButton by saving a reference
				// to it.
				selezionato = radioBB.IndexOf(rb);
			}
		}

	}
}
// TODO mettere a capo quando inserisci testo se càera
// metti inserimento ApyK