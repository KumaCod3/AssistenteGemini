using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace AssistenteGemini
{
	public partial class ThisAddIn
	{
		public static ThisAddIn _sinstance;

		private void ThisAddIn_Startup(object sender, System.EventArgs e)
		{
			if (_sinstance == null)
			{
				_sinstance = this;
			}
		}

		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
		{
		}

		#region Codice generato da VSTO

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(ThisAddIn_Startup);
			this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
		}

		#endregion

		public async System.Threading.Tasks.Task<string> SendRequestAndGetResponse(string userInput)
		{

			string jsonBody = $@"{{
				""contents"": [
					{{
						""role"": """",
						""parts"": [
							{{
								""text"": ""{userInput}""
							}}
						]
					}}
				],
				""generationConfig"": {{
					""temperature"": 0.9,
					""topK"": 50,
					""topP"": 0.95,
					""maxOutputTokens"": 4096,
					""stopSequences"": []
				}},
				""safetySettings"": [

				]
			}}";

			var request = new HttpRequestMessage(HttpMethod.Post, $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key={GeminiAssistant.myK}");
			request.Content = new StringContent(jsonBody, Encoding.UTF8);
			request.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");


			HttpClient httpClient = new HttpClient();
			var response = await httpClient.SendAsync(request).ConfigureAwait(false);


			if (response.IsSuccessStatusCode)
			{
				string responseBody = await response.Content.ReadAsStringAsync();
				return responseBody.Substring(responseBody.IndexOf("\"text\": \"") + 9, responseBody.IndexOf("\"", responseBody.IndexOf("\"text\": \"") + 10) - responseBody.IndexOf("\"text\": \"") - 9);
			}
			else
			{
				return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
			}
		}

		public static string chiediAgemini(string domanda)
		{
			if (GeminiAssistant.myK.Length == 0)
			{
				MessageBox.Show("You need to set your Gemini API key first!");
				return "";
			}

			string g = "" + domanda;
			string ss = "";
			if (_sinstance.Application.Selection.Text.Length > 1)
			{
				Microsoft.Office.Interop.Word.Selection currentSelection = _sinstance.Application.Selection;
				if (_sinstance.Application.Options.ReplaceSelection)
				{
					object direction = Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseStart;
					g = g + currentSelection.Text;

				}

				ss = _sinstance.SendRequestAndGetResponse(g).Result;
			}
			return ss;

		}

		public static void inserisciTesto(string testo)
		{
			Microsoft.Office.Interop.Word.Selection currentSelection = _sinstance.Application.Selection;

			// Store the user's current Overtype selection
			bool userOvertype = _sinstance.Application.Options.Overtype;

			// Make sure Overtype is turned off.
			if (_sinstance.Application.Options.Overtype)
			{
				_sinstance.Application.Options.Overtype = false;
			}

			// Test to see if selection is an insertion point.
			if (currentSelection.Type == Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionIP)
			{
				//currentSelection.TypeText(testo);
				currentSelection.Text = testo;
			}
			else
				if (currentSelection.Type == Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionNormal)
			{
				// Delete selection.
				if (_sinstance.Application.Options.ReplaceSelection)
				{
					object direction = Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseStart;
					currentSelection.Delete(ref direction);

				}
				//currentSelection.TypeText(testo);
				currentSelection.Text = testo;
			}
			else
			{
			}

			// Restore the user's Overtype selection	
			_sinstance.Application.Options.Overtype = userOvertype;

		}

		public static void debugga(string s)
		{
			MessageBox.Show(s);
		}
		public static void debugga()
		{
			debugga("prova");
		}
	}
}

