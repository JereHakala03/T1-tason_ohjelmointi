namespace Salasana
{
    partial class SalasanaFrom
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
            this.salasanaPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Label();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salasanaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPanel
            // 
            this.salasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPanel.Controls.Add(this.VirheviestiLB);
            this.salasanaPanel.Controls.Add(this.TarkistaBT);
            this.salasanaPanel.Controls.Add(this.SalasanaTB);
            this.salasanaPanel.Controls.Add(this.KayttajaTB);
            this.salasanaPanel.Controls.Add(this.label2);
            this.salasanaPanel.Controls.Add(this.label1);
            this.salasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaPanel.Name = "salasanaPanel";
            this.salasanaPanel.Size = new System.Drawing.Size(737, 259);
            this.salasanaPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.SalasanaOikeinPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 259);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.AutoSize = true;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(91, 17);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(551, 80);
            this.SalasanaOikeinPanel.TabIndex = 0;
            this.SalasanaOikeinPanel.Text = "Tervetuloa sivulleni";
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirheviestiLB.Location = new System.Drawing.Point(15, 131);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(60, 24);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "Virhe";
            this.VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TarkistaBT.Location = new System.Drawing.Point(19, 96);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(112, 32);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click_1);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(234, 99);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(187, 29);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTB.Location = new System.Drawing.Point(234, 37);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(187, 29);
            this.KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 259);
            this.Controls.Add(this.salasanaPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "SalasanaFrom";
            this.Text = "Salasanan tarkastus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.salasanaPanel.ResumeLayout(false);
            this.salasanaPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel salasanaPanel;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VirheviestiLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SalasanaOikeinPanel;
    }
}

