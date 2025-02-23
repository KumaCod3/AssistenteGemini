
namespace AssistenteGemini
{
	partial class Ribbon1: Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Ribbon1()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
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
			this.tab1 = this.Factory.CreateRibbonTab();
			this.group1 = this.Factory.CreateRibbonGroup();
			this.group2 = this.Factory.CreateRibbonGroup();
			this.adatta = this.Factory.CreateRibbonButton();
			this.button1 = this.Factory.CreateRibbonButton();
			this.button2 = this.Factory.CreateRibbonButton();
			this.button3 = this.Factory.CreateRibbonButton();
			this.button4 = this.Factory.CreateRibbonButton();
			this.button5 = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.group1.SuspendLayout();
			this.group2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.group1);
			this.tab1.Groups.Add(this.group2);
			this.tab1.Label = "GeminiAssistent";
			this.tab1.Name = "tab1";
			// 
			// group1
			// 
			this.group1.Items.Add(this.adatta);
			this.group1.Label = "Azione";
			this.group1.Name = "group1";
			// 
			// group2
			// 
			this.group2.Items.Add(this.button1);
			this.group2.Items.Add(this.button2);
			this.group2.Items.Add(this.button3);
			this.group2.Items.Add(this.button4);
			this.group2.Items.Add(this.button5);
			this.group2.Label = "Risposte";
			this.group2.Name = "group2";
			// 
			// adatta
			// 
			this.adatta.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.adatta.Label = "Sinonimi";
			this.adatta.Name = "adatta";
			this.adatta.ShowImage = true;
			this.adatta.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.adatta_Click);
			// 
			// button1
			// 
			this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button1.Label = "Prova di testo";
			this.button1.Name = "button1";
			this.button1.ShowImage = true;
			this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button2
			// 
			this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button2.Label = "Prova di testo";
			this.button2.Name = "button2";
			this.button2.ShowImage = true;
			this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button3
			// 
			this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button3.Label = "Prova di testo";
			this.button3.Name = "button3";
			this.button3.ShowImage = true;
			this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button4
			// 
			this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button4.Label = "Prova di testo";
			this.button4.Name = "button4";
			this.button4.ShowImage = true;
			this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// button5
			// 
			this.button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button5.Label = "Prova di testo";
			this.button5.Name = "button5";
			this.button5.ShowImage = true;
			this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.scelto_Click);
			// 
			// Ribbon1
			// 
			this.Name = "Ribbon1";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.group2.ResumeLayout(false);
			this.group2.PerformLayout();
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
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get
			{
				return this.GetRibbon<Ribbon1>();
			}
		}
	}
}
