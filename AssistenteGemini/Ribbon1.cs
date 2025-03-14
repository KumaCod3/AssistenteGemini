using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AssistenteGemini
{
	public partial class GeminiAssistant
	{
		public static List<string> prompts = new List<string>();


		public static string promptMod;
		public static string myK = "";
		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{

		}

		internal static void bakupK()
		{
			string path = "..\\beeK.txt";
			string createText = myK;
			File.WriteAllText(path, createText);
		}

		internal static void modK(string x)
		{
			myK = x;
		}

		private void sinonimi_Click(object sender, RibbonControlEventArgs e)
		{
			string domanda = "trova cinque sinonimi per la seguente parola, non mettere commenti, solo le singole parole, separate da ;";
			string risposta = ThisAddIn.chiediAgemini(domanda);
			if (risposta.Length > 0)
			{
				if (risposta.Equals("Error: BadRequest - Bad Request"))
				{
					MessageBox.Show("Bad Request, may be your Gemini API key?");
					return;
				}
				risposta = risposta.Replace("\\n", "");
				string[] tutt = risposta.Split(';');


				this.button1.Label = tutt[0];
				if (tutt.Length > 1)
					this.button2.Label = tutt[1];
				if (tutt.Length > 2)
					this.button3.Label = tutt[2];
				if (tutt.Length > 3)
					this.button4.Label = tutt[3];
				if (tutt.Length > 4)
					this.button5.Label = tutt[4];
			}
		}

		private void modProm_Click(object sender, RibbonControlEventArgs e)
		{
			Form1 mod = new Form1();
			mod.Visible = true;
			mod.Activate();
		}

		private void modK_Click(object sender, RibbonControlEventArgs e)
		{
			FormK mod = new FormK();
			mod.Visible = true;
			mod.Activate();
		}

		private void riscrivi_Click(object sender, RibbonControlEventArgs e)
		{
			string domanda = promptMod + " Proponi 3 alternative il più possibile diversificate in termini di lessico, ma sempre rispettando le linee guida iniziali. Fornisci solo le alternative senza titoli, introduzioni o spiegazioni o elenchi, e separale con  ;  ";
			string risposta = ThisAddIn.chiediAgemini(domanda);

			if (risposta.Length > 0)
			{

				risposta = risposta.Replace("\\n", "");
				string[] tutt = risposta.Split(';');

				this.button7.Label = tutt[0];
				if (tutt.Length > 1)
					this.button8.Label = tutt[1];
				if (tutt.Length > 2)
					this.button9.Label = tutt[2];
			}
		}
		private void scelto_Click1(object sender, RibbonControlEventArgs e)
		{
			RibbonButton bottone = (RibbonButton)sender;
			ThisAddIn.inserisciTesto(bottone.Label);
		}

		private void scelto_Click2(object sender, RibbonControlEventArgs e)
		{
			RibbonButton bottone = (RibbonButton)sender;
			ThisAddIn.inserisciTesto(bottone.Label + "\r");
		}
		public static void aggiungiPrompt(string pr)
		{
			promptMod = pr;
			if (prompts.Count < 6)
			{
				prompts.Add(pr);
			}
		}


		public void inizia()
		{
			string pathP = "..\\prompp.txt";
			string pathK = "..\\beeK.txt";

			// To read a text file line by line 
			if (File.Exists(pathP))
			{
				// Store each line in array of strings 
				string[] lines = File.ReadAllLines(pathP);

				foreach (string ln in lines)
				{
					prompts.Add(ln);
				}
				promptMod = prompts[0];
			}


			if (File.Exists(pathK))
			{
				string k = File.ReadAllText(pathK);
				myK = k;
			}
		}
		public static void bakupPrompt()
		{
			string path = "..\\prompp.txt";
			string createText = "";
			foreach (string ln in prompts)
			{
				createText = createText + ln + Environment.NewLine;
			}
			File.WriteAllText(path, createText);
		}
	}
}