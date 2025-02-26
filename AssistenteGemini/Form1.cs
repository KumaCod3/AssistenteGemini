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
		}

		private void modProm_Click(object sender, System.EventArgs e)
		{
			string x = "";
			x = this.textBox1.Text;
			Ribbon1.promptMod = x;
			this.Close();
		}
	}
}
