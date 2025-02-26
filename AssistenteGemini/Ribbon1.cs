using Microsoft.Office.Tools.Ribbon;

namespace AssistenteGemini
{
	public partial class Ribbon1
	{

		public static string promptMod = "Riscrivi il testo con uno stile ricercato utilizzando termini desueti e arcaici. ";
		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void sinonimi_Click(object sender, RibbonControlEventArgs e)
		{
			string domanda = "trova cinque sinonimi per la seguente parola, non mettere commenti, solo le singole parole, separate da ;";
			string risposta = ThisAddIn.chiediAgemini(domanda);
			risposta = risposta.Replace("\\n", "");
			string[] tutt = risposta.Split(';');

			// TODO  /n e controlla trailing spazio



			this.button1.Label = tutt[0];
			this.button2.Label = tutt[1];
			this.button3.Label = tutt[2];
			this.button4.Label = tutt[3];
			this.button5.Label = tutt[4];
		}

		private void modProm_Click(object sender, RibbonControlEventArgs e)
		{
			Form1 mod = new Form1();
			mod.Visible = true;
			mod.Activate();
		}

		private void riscrivi_Click(object sender, RibbonControlEventArgs e)
		{
			string domanda = promptMod + " Proponi 3 alternative il più possibile diversificate in termini di lessico, ma sempre rispettando le linee guida iniziali. Fornisci solo le alternative senza titoli, introduzioni o spiegazioni o elenchi, separale con  ; ";
			string risposta = ThisAddIn.chiediAgemini(domanda);
			risposta = risposta.Replace("\\n", "");
			string[] tutt = risposta.Split(';');

			// TODO  /n e controlla trailing spazio



			this.button7.Label = tutt[0];
			this.button8.Label = tutt[1];
			this.button9.Label = tutt[2];
		}
		private void scelto_Click(object sender, RibbonControlEventArgs e)
		{
			RibbonButton bottone = (RibbonButton)sender;
			ThisAddIn.inserisciTesto(bottone.Label);
		}

	}
}
