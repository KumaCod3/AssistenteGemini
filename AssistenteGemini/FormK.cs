using System.Windows.Forms;

namespace AssistenteGemini
{
	public partial class FormK: Form
	{
		public FormK()
		{
			InitializeComponent();
			string myK = GeminiAssistant.myK;
			this.textBox1.Text = myK;
			
		}

		private void modK_Click(object sender, System.EventArgs e)
		{
			string x = "";
			x = this.textBox1.Text;
			GeminiAssistant.modK(x);
			GeminiAssistant.bakupK();
			this.Close();
		}
	}
}
