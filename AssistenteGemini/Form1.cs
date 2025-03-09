using System.Windows.Forms;

namespace AssistenteGemini
{
	public partial class Form1: Form
	{
		public Form1()
		{
			InitializeComponent();
			string oldPrompt = Ribbon1.promptMod;
			this.textBox1.Text = oldPrompt;
			System.Drawing.Point loc = new System.Drawing.Point(358, 20);

			foreach (string pr in Ribbon1.prompts)
			{
				RadioButton radioButton = new RadioButton();
				this.Controls.Add(radioButton);
				radioButton.Text = pr;
				radioButton.Location = loc;
				radioButton.Size = new System.Drawing.Size(350, 40);
				radioButton.AutoSize = false;
				loc.Y = loc.Y + 40;
			}

		}

		private void modProm_Click(object sender, System.EventArgs e)
		{
			string x = "";
			x = this.textBox1.Text;
			Ribbon1.aggiungiPrompt(x);
			this.Close();
		}

		private void selezPromp(int x)
		{
			Ribbon1.promptMod = Ribbon1.prompts[x];
		}

	}
}
// TODO mettere a capo quando inserisci testo se càera
// fare funzionamento radioButton
// metti inserimento ApyK