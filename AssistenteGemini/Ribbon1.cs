using Microsoft.Office.Tools.Ribbon;

namespace AssistenteGemini
{
	public partial class Ribbon1
	{
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

		private void riscrivi_Click(object sender, RibbonControlEventArgs e)
		{
			string domanda = "riscrivi questo brano utilizzando lo stile di riferimento fornito: lo stile di riferimento deve essere questo: \"Sileno affondò la mano nel ventre squarciato del frutto verminoso. Attraversò la placenta, scrigno di semi esangui, e raggiunse ciò che restava di uno dei figli dell’albero eterno. Il feto aveva il colore dell’oceano in tempesta ed era avvolto da una materia lattea simile a neve infangata, gelida e grigiastra. Il cacciatore di bezoar era accovacciato al suolo, col cuore palpitante d’ansia e concitazione. Quel fruscio di foglie era opera del vento o di uno dei numi? Si domandò. Quel ramo scricchiolava sotto il peso di uno stivale oppure dello zoccolo di un cervide? Infilò la mano nell’arabesco di capillari sfaldati. Perché Etra era lì al suo fianco? Quella follia era per lei, certo, il primo passo di un lungo cammino che gli avrebbe permesso di esprimere il desiderio assoluto, di mutare per sempre le sorti della netide a cui aveva votato la sua esistenza. Lei era lì accanto, scrutava le ombre con occhi color pece, i suoi petali fremevano silenti, bramosi di suoni a lui celati. Se manteneva la sua quiete significava che avevano ancora tempo, che i numi a guardia dell’albero, erano ancora lontani.\" Proponi 5 alternative il più possibile diversificate in termini di lessico, ma sempre rispettando le linee guida iniziali.Fornisci solo le alternative senza titoli, introduzioni o spiegazioni, separate da;";
			string risposta = ThisAddIn.chiediAgemini(domanda);
			risposta = risposta.Replace("\\\n", "");
			string[] tutt = risposta.Split(';');

			// TODO  /n e controlla trailing spazio



			this.button7.Label = tutt[0];
			/*			this.button8.Label = tutt[1];
						this.button9.Label = tutt[2];
						this.button10.Label = tutt[3];
						this.button11.Label = tutt[4];*/
		}
		private void scelto_Click(object sender, RibbonControlEventArgs e)
		{
			RibbonButton bottone = (RibbonButton)sender;
			ThisAddIn.inserisciTesto(bottone.Label);
		}

	}
}
