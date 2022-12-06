
namespace _08_HB_S45A1_BMI
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
            this.txtEingabeCm = new System.Windows.Forms.TextBox();
            this.txtEingabeKg = new System.Windows.Forms.TextBox();
            this.btnRechnen = new System.Windows.Forms.Button();
            this.txtAusgabeBMIWert = new System.Windows.Forms.TextBox();
            this.txtAusgabeBMI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Größe in CM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gewicht in Kg:";
            // 
            // txtEingabeCm
            // 
            this.txtEingabeCm.Location = new System.Drawing.Point(166, 42);
            this.txtEingabeCm.Name = "txtEingabeCm";
            this.txtEingabeCm.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeCm.TabIndex = 2;
            // 
            // txtEingabeKg
            // 
            this.txtEingabeKg.Location = new System.Drawing.Point(166, 89);
            this.txtEingabeKg.Name = "txtEingabeKg";
            this.txtEingabeKg.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeKg.TabIndex = 3;
            // 
            // btnRechnen
            // 
            this.btnRechnen.Location = new System.Drawing.Point(15, 136);
            this.btnRechnen.Name = "btnRechnen";
            this.btnRechnen.Size = new System.Drawing.Size(251, 29);
            this.btnRechnen.TabIndex = 4;
            this.btnRechnen.Text = "BMI Berechnen";
            this.btnRechnen.UseVisualStyleBackColor = true;
            this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
            // 
            // txtAusgabeBMIWert
            // 
            this.txtAusgabeBMIWert.Location = new System.Drawing.Point(166, 227);
            this.txtAusgabeBMIWert.Name = "txtAusgabeBMIWert";
            this.txtAusgabeBMIWert.ReadOnly = true;
            this.txtAusgabeBMIWert.Size = new System.Drawing.Size(188, 20);
            this.txtAusgabeBMIWert.TabIndex = 8;
            // 
            // txtAusgabeBMI
            // 
            this.txtAusgabeBMI.Location = new System.Drawing.Point(166, 183);
            this.txtAusgabeBMI.Name = "txtAusgabeBMI";
            this.txtAusgabeBMI.ReadOnly = true;
            this.txtAusgabeBMI.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBMI.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interpretation des BMI-Wertes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 285);
            this.Controls.Add(this.txtAusgabeBMIWert);
            this.Controls.Add(this.txtAusgabeBMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRechnen);
            this.Controls.Add(this.txtEingabeKg);
            this.Controls.Add(this.txtEingabeCm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEingabeCm;
        private System.Windows.Forms.TextBox txtEingabeKg;
        private System.Windows.Forms.Button btnRechnen;
        private System.Windows.Forms.TextBox txtAusgabeBMIWert;
        private System.Windows.Forms.TextBox txtAusgabeBMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

