using Microsoft.Office.Tools.Ribbon;

namespace AssistenteGemini
{
	public partial class Ribbon1
	{
		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void adatta_Click(object sender, RibbonControlEventArgs e)
		{
			string domanda = "traduci in inglese il testo: ";
			string risposta = ThisAddIn.chiediAgemini(domanda);
			this.button1.Label = risposta;
		}
		private void scelto_Click(object sender, RibbonControlEventArgs e)
		{
			RibbonButton bottone = (RibbonButton)sender;
			ThisAddIn.inserisciTesto(bottone.Label);
		}

	}
}
