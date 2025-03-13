
namespace AssistenteGemini
{
	partial class GeminiAssistant: Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public GeminiAssistant()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
			inizia();
		}

		/// <summary> 
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione componenti

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeminiAssistant));
			this.tab1 = this.Factory.CreateRibbonTab();
			this.group1 = this.Factory.CreateRibbonGroup();
			this.group2 = this.Factory.CreateRibbonGroup();
			this.group3 = this.Factory.CreateRibbonGroup();
			this.adatta = this.Factory.CreateRibbonButton();
			this.button1 = this.Factory.CreateRibbonButton();
			this.button2 = this.Factory.CreateRibbonButton();
			this.button3 = this.Factory.CreateRibbonButton();
			this.button4 = this.Factory.CreateRibbonButton();
			this.button5 = this.Factory.CreateRibbonButton();
			this.button6 = this.Factory.CreateRibbonButton();
			this.button10 = this.Factory.CreateRibbonButton();
			this.button7 = this.Factory.CreateRibbonButton();
			this.button8 = this.Factory.CreateRibbonButton();
			this.button9 = this.Factory.CreateRibbonButton();
			this.button11 = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.group1.SuspendLayout();
			this.group2.SuspendLayout();
			this.group3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.group2);
			this.tab1.Groups.Add(this.group1);
			this.tab1.Groups.Add(this.group3);
			this.tab1.Label = "Gemini Assistant";
			this.tab1.Name = "tab1";
			// 
			// group1
			// 
			this.group1.Items.Add(this.adatta);
			this.group1.Items.Add(this.button1);
			this.group1.Items.Add(this.button2);
			this.group1.Items.Add(this.button3);
			this.group1.Items.Add(this.button4);
			this.group1.Items.Add(this.button5);
			this.group1.Label = "Sinonimi";
			this.group1.Name = "group1";
			// 
			// group2
			// 
			this.group2.Items.Add(this.button11);
			this.group2.Label = "apiK";
			this.group2.Name = "group2";
			// 
			// group3
			// 
			this.group3.Items.Add(this.button6);
			this.group3.Items.Add(this.button10);
			this.group3.Items.Add(this.button8);
			this.group3.Items.Add(this.button7);
			this.group3.Items.Add(this.button9);
			this.group3.Label = "Riscrivi";
			this.group3.Name = "group3";
			// 
			// adatta
			// 
			this.adatta.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.adatta.Image = ((System.Drawing.Image)(resources.GetObject("adatta.Image")));
			this.adatta.Label = "Synonyms";
			this.adatta.Name = "adatta";
			this.adatta.ShowImage = true;
			this.adatta.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sinonimi_Click);
			// 
			// button1
			// 
			this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Label = "Option 1";
			this.button1.Name = "button1";
			this.button1.ShowImage = true;
			this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button2
			// 
			this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Label = "Option 2";
			this.button2.Name = "button2";
			this.button2.ShowImage = true;
			this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button3
			// 
			this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Label = "Option 3";
			this.button3.Name = "button3";
			this.button3.ShowImage = true;
			this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button4
			// 
			this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Label = "Option 4";
			this.button4.Name = "button4";
			this.button4.ShowImage = true;
			this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button5
			// 
			this.button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Label = "Option 5";
			this.button5.Name = "button5";
			this.button5.ShowImage = true;
			this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button6
			// 
			this.button6.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Label = "Change Text";
			this.button6.Name = "button6";
			this.button6.ShowImage = true;
			this.button6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.riscrivi_Click);
			// 
			// button10
			// 
			this.button10.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
			this.button10.Label = "Prompts";
			this.button10.Name = "button10";
			this.button10.ShowImage = true;
			this.button10.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.modProm_Click);
			// 
			// button7
			// 
			this.button7.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.Label = "Option 1";
			this.button7.Name = "button7";
			this.button7.ShowImage = true;
			this.button7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button8
			// 
			this.button8.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
			this.button8.Label = "Option 2";
			this.button8.Name = "button8";
			this.button8.ShowImage = true;
			this.button8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button9
			// 
			this.button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
			this.button9.Label = "Option 3";
			this.button9.Name = "button9";
			this.button9.ShowImage = true;
			this.button9.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button11
			// 
			this.button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
			this.button11.Label = "myAPIk";
			this.button11.Name = "button11";
			this.button11.ShowImage = true;
			this.button11.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.modK_Click);
			// 
			// GeminiAssistant
			// 
			this.Name = "GeminiAssistant";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.group2.ResumeLayout(false);
			this.group2.PerformLayout();
			this.group3.ResumeLayout(false);
			this.group3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton adatta;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button10;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button11;
	}

	partial class ThisRibbonCollection
	{
		internal GeminiAssistant Ribbon1
		{
			get
			{
				return this.GetRibbon<GeminiAssistant>();
			}
		}
	}
}
