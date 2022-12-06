
namespace _07_HB_S4243_Reise
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEingabeKind = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAusgabeNetto2Erw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAusgabeNettoKind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAusgabeNetto2Erwachsene = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAusgabeBrutto2Erwachsene = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pauschalreise: 2 Erwachsene und 1 Kind, 7 Tage.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geben sie bitte das des Kindes an:\r\n";
            // 
            // txtEingabeKind
            // 
            this.txtEingabeKind.Location = new System.Drawing.Point(277, 47);
            this.txtEingabeKind.Name = "txtEingabeKind";
            this.txtEingabeKind.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeKind.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(156, 87);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(181, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Berechnung der Preise";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAusgabeNetto2Erw
            // 
            this.txtAusgabeNetto2Erw.Location = new System.Drawing.Point(277, 128);
            this.txtAusgabeNetto2Erw.Name = "txtAusgabeNetto2Erw";
            this.txtAusgabeNetto2Erw.ReadOnly = true;
            this.txtAusgabeNetto2Erw.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNetto2Erw.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Der Nettopreis für 2 Erwachsene beträgt:\r\n";
            // 
            // txtAusgabeNettoKind
            // 
            this.txtAusgabeNettoKind.Location = new System.Drawing.Point(277, 165);
            this.txtAusgabeNettoKind.Name = "txtAusgabeNettoKind";
            this.txtAusgabeNettoKind.ReadOnly = true;
            this.txtAusgabeNettoKind.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNettoKind.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Der Nettopreis für ein Kind beträgt:\r\n";
            // 
            // txtAusgabeNetto2Erwachsene
            // 
            this.txtAusgabeNetto2Erwachsene.Location = new System.Drawing.Point(277, 200);
            this.txtAusgabeNetto2Erwachsene.Name = "txtAusgabeNetto2Erwachsene";
            this.txtAusgabeNetto2Erwachsene.ReadOnly = true;
            this.txtAusgabeNetto2Erwachsene.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNetto2Erwachsene.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Der Nettopreis für 2 Erwachsene und ein Kind beträgt:\r\n";
            // 
            // txtAusgabeBrutto2Erwachsene
            // 
            this.txtAusgabeBrutto2Erwachsene.Location = new System.Drawing.Point(277, 235);
            this.txtAusgabeBrutto2Erwachsene.Name = "txtAusgabeBrutto2Erwachsene";
            this.txtAusgabeBrutto2Erwachsene.ReadOnly = true;
            this.txtAusgabeBrutto2Erwachsene.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBrutto2Erwachsene.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Der Bruttopreis für 2 Erwachsene und ein Kind beträgt:\r\n";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 344);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAusgabeBrutto2Erwachsene);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAusgabeNetto2Erwachsene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAusgabeNettoKind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAusgabeNetto2Erw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtEingabeKind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pauschalreise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEingabeKind;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAusgabeNetto2Erw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAusgabeNettoKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAusgabeNetto2Erwachsene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAusgabeBrutto2Erwachsene;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
    }
}

