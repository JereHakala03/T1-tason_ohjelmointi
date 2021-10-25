
namespace WindowsFormsApp1
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
			this.OtsikkoLB = new System.Windows.Forms.Label();
			this.VaihdaBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OtsikkoLB
			// 
			this.OtsikkoLB.AutoSize = true;
			this.OtsikkoLB.Location = new System.Drawing.Point(456, 197);
			this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.OtsikkoLB.Name = "OtsikkoLB";
			this.OtsikkoLB.Size = new System.Drawing.Size(115, 29);
			this.OtsikkoLB.TabIndex = 0;
			this.OtsikkoLB.Text = "Otsikko1";
			// 
			// VaihdaBT
			// 
			this.VaihdaBT.Location = new System.Drawing.Point(444, 229);
			this.VaihdaBT.Name = "VaihdaBT";
			this.VaihdaBT.Size = new System.Drawing.Size(127, 66);
			this.VaihdaBT.TabIndex = 1;
			this.VaihdaBT.Text = "button1";
			this.VaihdaBT.UseVisualStyleBackColor = true;
			this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 595);
			this.Controls.Add(this.VaihdaBT);
			this.Controls.Add(this.OtsikkoLB);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "Form1";
			this.Text = "Harjoitus1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label OtsikkoLB;
		private System.Windows.Forms.Button VaihdaBT;
	}
}

