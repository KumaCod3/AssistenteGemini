﻿
namespace AssistenteGemini
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inserisci new prompt:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(53, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.modProm_Click);
			// 
			// textBox1
			// 
			this.textBox1.AccessibleName = "textBox1";
			this.textBox1.Location = new System.Drawing.Point(53, 60);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(299, 186);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(376, 282);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 45);
			this.button2.TabIndex = 3;
			this.button2.Text = "Choose Selected";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.selez_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(626, 282);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(118, 45);
			this.button3.TabIndex = 4;
			this.button3.Text = "Delete Selected";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.elim_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 339);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Modifica Prompt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}