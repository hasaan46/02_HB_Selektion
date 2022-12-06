
namespace _03_HB_S39A2_AutoVermietung
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
            this.txtEingabeKm = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAusgabeNetto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAusgabeMwSt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normaltarif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "gefahrene km:";
            // 
            // txtEingabeKm
            // 
            this.txtEingabeKm.Location = new System.Drawing.Point(143, 42);
            this.txtEingabeKm.Name = "txtEingabeKm";
            this.txtEingabeKm.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeKm.TabIndex = 2;
            this.txtEingabeKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 78);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(228, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Rechnungsbetrag berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAusgabeNetto
            // 
            this.txtAusgabeNetto.Location = new System.Drawing.Point(143, 128);
            this.txtAusgabeNetto.Name = "txtAusgabeNetto";
            this.txtAusgabeNetto.ReadOnly = true;
            this.txtAusgabeNetto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNetto.TabIndex = 5;
            this.txtAusgabeNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rechnungsbetrag Netto";
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(143, 167);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBrutto.TabIndex = 7;
            this.txtAusgabeBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rechnungsbetrag Brutto";
            // 
            // txtAusgabeMwSt
            // 
            this.txtAusgabeMwSt.Location = new System.Drawing.Point(143, 203);
            this.txtAusgabeMwSt.Name = "txtAusgabeMwSt";
            this.txtAusgabeMwSt.ReadOnly = true;
            this.txtAusgabeMwSt.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeMwSt.TabIndex = 9;
            this.txtAusgabeMwSt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "enthaltende MwSt";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(19, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(224, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Anwendung schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 276);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAusgabeMwSt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAusgabeNetto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtEingabeKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Autovermietung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEingabeKm;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAusgabeNetto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAusgabeMwSt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }
}

