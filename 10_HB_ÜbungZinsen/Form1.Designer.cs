namespace HB_10_ÜbungZinsen
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
            this.txtEingabeEuro = new System.Windows.Forms.TextBox();
            this.rBtnAnlage = new System.Windows.Forms.RadioButton();
            this.chkGesamt = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAusgabeJahr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anlagebetrag in Euro";
            // 
            // txtEingabeEuro
            // 
            this.txtEingabeEuro.Location = new System.Drawing.Point(166, 35);
            this.txtEingabeEuro.Name = "txtEingabeEuro";
            this.txtEingabeEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeEuro.TabIndex = 1;
            // 
            // rBtnAnlage
            // 
            this.rBtnAnlage.Location = new System.Drawing.Point(12, 74);
            this.rBtnAnlage.Name = "rBtnAnlage";
            this.rBtnAnlage.Size = new System.Drawing.Size(308, 24);
            this.rBtnAnlage.TabIndex = 2;
            this.rBtnAnlage.TabStop = true;
            this.rBtnAnlage.Text = "Anlage für 2 Jahre fest (Zinssatz erhöht sich 0,25% p.a)";
            this.rBtnAnlage.UseVisualStyleBackColor = true;
            // 
            // chkGesamt
            // 
            this.chkGesamt.Location = new System.Drawing.Point(12, 115);
            this.chkGesamt.Name = "chkGesamt";
            this.chkGesamt.Size = new System.Drawing.Size(254, 24);
            this.chkGesamt.TabIndex = 3;
            this.chkGesamt.Text = "Nach der Berechnung den Gesamtbetrag anezigen";
            this.chkGesamt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Berechnung der Jährlichen Zinszahlung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAusgabeJahr
            // 
            this.txtAusgabeJahr.Location = new System.Drawing.Point(166, 198);
            this.txtAusgabeJahr.Name = "txtAusgabeJahr";
            this.txtAusgabeJahr.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeJahr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zinszahlung pro Jahr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 249);
            this.Controls.Add(this.txtAusgabeJahr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkGesamt);
            this.Controls.Add(this.rBtnAnlage);
            this.Controls.Add(this.txtEingabeEuro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAusgabeJahr;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.CheckBox chkGesamt;

        private System.Windows.Forms.RadioButton rBtnAnlage;

        private System.Windows.Forms.TextBox txtEingabeEuro;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}