
namespace _04_HB_S42A1_Schrauben
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
            this.txtEingabeStück = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAusgabeListen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAusgabeVersand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAusgabeRabatt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAusgabeGesamt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stückzahl";
            // 
            // txtEingabeStück
            // 
            this.txtEingabeStück.Location = new System.Drawing.Point(111, 6);
            this.txtEingabeStück.Name = "txtEingabeStück";
            this.txtEingabeStück.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeStück.TabIndex = 1;
            this.txtEingabeStück.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 32);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(289, 31);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Berechnen gesamtpreis";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAusgabeListen
            // 
            this.txtAusgabeListen.Location = new System.Drawing.Point(111, 80);
            this.txtAusgabeListen.Name = "txtAusgabeListen";
            this.txtAusgabeListen.ReadOnly = true;
            this.txtAusgabeListen.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeListen.TabIndex = 4;
            this.txtAusgabeListen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listenpreis";
            // 
            // txtAusgabeVersand
            // 
            this.txtAusgabeVersand.Location = new System.Drawing.Point(111, 157);
            this.txtAusgabeVersand.Name = "txtAusgabeVersand";
            this.txtAusgabeVersand.ReadOnly = true;
            this.txtAusgabeVersand.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeVersand.TabIndex = 6;
            this.txtAusgabeVersand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Versandgebühren";
            // 
            // txtAusgabeRabatt
            // 
            this.txtAusgabeRabatt.Location = new System.Drawing.Point(111, 118);
            this.txtAusgabeRabatt.Name = "txtAusgabeRabatt";
            this.txtAusgabeRabatt.ReadOnly = true;
            this.txtAusgabeRabatt.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeRabatt.TabIndex = 8;
            this.txtAusgabeRabatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rabatt";
            // 
            // txtAusgabeGesamt
            // 
            this.txtAusgabeGesamt.Location = new System.Drawing.Point(111, 197);
            this.txtAusgabeGesamt.Name = "txtAusgabeGesamt";
            this.txtAusgabeGesamt.ReadOnly = true;
            this.txtAusgabeGesamt.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeGesamt.TabIndex = 10;
            this.txtAusgabeGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gesamtpreis";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(289, 31);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Anwendung beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 287);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAusgabeGesamt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAusgabeRabatt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAusgabeVersand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAusgabeListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtEingabeStück);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Schrauben - Berechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEingabeStück;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAusgabeListen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAusgabeVersand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAusgabeRabatt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAusgabeGesamt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }
}

