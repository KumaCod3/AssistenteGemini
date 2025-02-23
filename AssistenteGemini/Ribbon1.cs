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
			string domanda = "trova cinque sinonimi per la seguente parola, non mettere commenti, solo le singole parole, separate da ; ";
			string risposta = ThisAddIn.chiediAgemini(domanda);
			risposta = risposta.Replace("\\\n", "");
			string[] tutt = risposta.Split(';');

			// TODO  /n e controlla trailing spazio






			this.button1.Label = tutt[0];
			this.button2.Label = tutt[1];
			this.button3.Label = tutt[2];
			this.button4.Label = tutt[3];
			this.button5.Label = tutt[4];
		}
		private void scelto_Click(object sender, RibbonControlEventArgs e)
		{
			RibbonButton bottone = (RibbonButton)sender;
			ThisAddIn.inserisciTesto(bottone.Label);
		}

	}
}
