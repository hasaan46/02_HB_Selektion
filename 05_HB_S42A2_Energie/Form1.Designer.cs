
namespace _05_HB_S42A2_Energie
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
            this.txtEingabeliter = new System.Windows.Forms.TextBox();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.txtEingabePersonen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEingabeWohnfläche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAusgabekWh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAusgabeVerbrauch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAusgabekennzahl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAusgabeHinweis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gesamtverbrauch in Liter oder m³";
            // 
            // txtEingabeliter
            // 
            this.txtEingabeliter.Location = new System.Drawing.Point(203, 52);
            this.txtEingabeliter.Name = "txtEingabeliter";
            this.txtEingabeliter.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeliter.TabIndex = 1;
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Location = new System.Drawing.Point(6, 36);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(36, 17);
            this.rBtnYes.TabIndex = 2;
            this.rBtnYes.Text = "Ja";
            this.rBtnYes.UseVisualStyleBackColor = true;
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(75, 36);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(47, 17);
            this.rBtnNo.TabIndex = 4;
            this.rBtnNo.Text = "Nein";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // txtEingabePersonen
            // 
            this.txtEingabePersonen.Location = new System.Drawing.Point(163, 166);
            this.txtEingabePersonen.Name = "txtEingabePersonen";
            this.txtEingabePersonen.Size = new System.Drawing.Size(100, 20);
            this.txtEingabePersonen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anzahl Personen im Haushalt";
            // 
            // txtEingabeWohnfläche
            // 
            this.txtEingabeWohnfläche.Location = new System.Drawing.Point(370, 166);
            this.txtEingabeWohnfläche.Name = "txtEingabeWohnfläche";
            this.txtEingabeWohnfläche.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeWohnfläche.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wohnfläche in m²";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 201);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(455, 37);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Auswerten des Energieverbrauches";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAusgabekWh
            // 
            this.txtAusgabekWh.Location = new System.Drawing.Point(137, 257);
            this.txtAusgabekWh.Name = "txtAusgabekWh";
            this.txtAusgabekWh.ReadOnly = true;
            this.txtAusgabekWh.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabekWh.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verbrauch in kWh";
            // 
            // txtAusgabeVerbrauch
            // 
            this.txtAusgabeVerbrauch.Location = new System.Drawing.Point(137, 298);
            this.txtAusgabeVerbrauch.Name = "txtAusgabeVerbrauch";
            this.txtAusgabeVerbrauch.ReadOnly = true;
            this.txtAusgabeVerbrauch.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeVerbrauch.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tatsächlicherverbrauch";
            // 
            // txtAusgabekennzahl
            // 
            this.txtAusgabekennzahl.Location = new System.Drawing.Point(309, 298);
            this.txtAusgabekennzahl.Name = "txtAusgabekennzahl";
            this.txtAusgabekennzahl.ReadOnly = true;
            this.txtAusgabekennzahl.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabekennzahl.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kennzahl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "kWh/m²";
            // 
            // txtAusgabeHinweis
            // 
            this.txtAusgabeHinweis.Location = new System.Drawing.Point(137, 335);
            this.txtAusgabeHinweis.Name = "txtAusgabeHinweis";
            this.txtAusgabeHinweis.ReadOnly = true;
            this.txtAusgabeHinweis.Size = new System.Drawing.Size(272, 20);
            this.txtAusgabeHinweis.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hinweis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnYes);
            this.groupBox1.Controls.Add(this.rBtnNo);
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 82);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wird die Heizung für Warmwasser verwendet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAusgabeHinweis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAusgabekennzahl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAusgabeVerbrauch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAusgabekWh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtEingabeWohnfläche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEingabePersonen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEingabeliter);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Energievebrauchkennwert";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEingabeliter;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.TextBox txtEingabePersonen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEingabeWohnfläche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAusgabekWh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAusgabeVerbrauch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAusgabekennzahl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAusgabeHinweis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

