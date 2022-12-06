
namespace _01_HB_Prämie
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
            this.lblJahresUmsatz = new System.Windows.Forms.Label();
            this.txtBoxUmsatz = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBoxPreamie = new System.Windows.Forms.TextBox();
            this.lblPrämie = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJahresUmsatz
            // 
            this.lblJahresUmsatz.AutoSize = true;
            this.lblJahresUmsatz.Location = new System.Drawing.Point(12, 27);
            this.lblJahresUmsatz.Name = "lblJahresUmsatz";
            this.lblJahresUmsatz.Size = new System.Drawing.Size(74, 13);
            this.lblJahresUmsatz.TabIndex = 0;
            this.lblJahresUmsatz.Text = "Jahresumsatz:";
            // 
            // txtBoxUmsatz
            // 
            this.txtBoxUmsatz.Location = new System.Drawing.Point(92, 24);
            this.txtBoxUmsatz.Name = "txtBoxUmsatz";
            this.txtBoxUmsatz.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUmsatz.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 61);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(177, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Prämie berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBoxPreamie
            // 
            this.txtBoxPreamie.Location = new System.Drawing.Point(92, 106);
            this.txtBoxPreamie.Name = "txtBoxPreamie";
            this.txtBoxPreamie.ReadOnly = true;
            this.txtBoxPreamie.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPreamie.TabIndex = 4;
            // 
            // lblPrämie
            // 
            this.lblPrämie.AutoSize = true;
            this.lblPrämie.Location = new System.Drawing.Point(17, 109);
            this.lblPrämie.Name = "lblPrämie";
            this.lblPrämie.Size = new System.Drawing.Size(42, 13);
            this.lblPrämie.TabIndex = 3;
            this.lblPrämie.Text = "Prämie:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 159);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 216);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBoxPreamie);
            this.Controls.Add(this.lblPrämie);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxUmsatz);
            this.Controls.Add(this.lblJahresUmsatz);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jahresumsatz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJahresUmsatz;
        private System.Windows.Forms.TextBox txtBoxUmsatz;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtBoxPreamie;
        private System.Windows.Forms.Label lblPrämie;
        private System.Windows.Forms.Button btnClose;
    }
}

