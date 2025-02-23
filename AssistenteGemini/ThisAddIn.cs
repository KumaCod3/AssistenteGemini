//using System.Xml.Linq;
//using Word = Microsoft.Office.Interop.Word;
//using Office = Microsoft.Office.Core;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using Microsoft.Office.Interop.Word; // Già presente, assicura di averlo
//using System.Windows.Forms; // Per MessageBox


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

		private string GEMINI_API_KEY = "ddd";

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

			var request = new HttpRequestMessage(HttpMethod.Post, $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key={GEMINI_API_KEY}");
			request.Content = new StringContent(jsonBody, Encoding.UTF8);
			request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");


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
			string g = "" + domanda;
			Microsoft.Office.Interop.Word.Selection currentSelection = _sinstance.Application.Selection;
			if (_sinstance.Application.Options.ReplaceSelection)
			{
				object direction = Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseStart;
				g = g + currentSelection.Text;

			}

			string ss = _sinstance.SendRequestAndGetResponse(g).Result;
			return ss;
		}

		public static void inserisciTesto(string testo)
		{
			//		Microsoft.Office.Interop.Word.Range rng = ;
			//	rng.Text = testo;


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
				currentSelection.TypeText(testo);
				currentSelection.TypeParagraph();
			}
			else
				if (currentSelection.Type == Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionNormal)
			{
				// Move to start of selection.
				if (_sinstance.Application.Options.ReplaceSelection)
				{
					object direction = Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseStart;
					currentSelection.Delete(ref direction);

				}
				currentSelection.TypeText(testo);
				currentSelection.TypeParagraph();
			}
			else
			{
				// Do nothing.
			}

			// Restore the user's Overtype selection
			_sinstance.Application.Options.Overtype = userOvertype;

		}

	}
}

