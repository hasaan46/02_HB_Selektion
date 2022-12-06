
namespace _02_HB_S38_Angebot
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
            this.txtEingabeAufenthaltsdauer = new System.Windows.Forms.TextBox();
            this.txtEingabePersonen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAusgabeNetto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eingabe Aufenthaltsdauer:";
            // 
            // txtEingabeAufenthaltsdauer
            // 
            this.txtEingabeAufenthaltsdauer.Location = new System.Drawing.Point(150, 6);
            this.txtEingabeAufenthaltsdauer.Name = "txtEingabeAufenthaltsdauer";
            this.txtEingabeAufenthaltsdauer.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeAufenthaltsdauer.TabIndex = 1;
            this.txtEingabeAufenthaltsdauer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEingabePersonen
            // 
            this.txtEingabePersonen.Location = new System.Drawing.Point(150, 45);
            this.txtEingabePersonen.Name = "txtEingabePersonen";
            this.txtEingabePersonen.Size = new System.Drawing.Size(100, 20);
            this.txtEingabePersonen.TabIndex = 3;
            this.txtEingabePersonen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl Personen:";
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(150, 170);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBrutto.TabIndex = 7;
            this.txtAusgabeBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brutto:";
            // 
            // txtAusgabeNetto
            // 
            this.txtAusgabeNetto.Location = new System.Drawing.Point(150, 131);
            this.txtAusgabeNetto.Name = "txtAusgabeNetto";
            this.txtAusgabeNetto.ReadOnly = true;
            this.txtAusgabeNetto.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeNetto.TabIndex = 5;
            this.txtAusgabeNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Netto:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(21, 83);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(229, 35);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Angebot berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 219);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAusgabeNetto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEingabePersonen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEingabeAufenthaltsdauer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hotelpreis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEingabeAufenthaltsdauer;
        private System.Windows.Forms.TextBox txtEingabePersonen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAusgabeNetto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
    }
}

