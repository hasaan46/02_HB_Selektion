namespace HB_09_S45A2_Prämie
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
            this.txtEingabeDauerBeschäftigung = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.txtAusgabePrämie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dauer der Beschäftigung in ganzen Jahren:";
            // 
            // txtEingabeDauerBeschäftigung
            // 
            this.txtEingabeDauerBeschäftigung.Location = new System.Drawing.Point(247, 50);
            this.txtEingabeDauerBeschäftigung.Name = "txtEingabeDauerBeschäftigung";
            this.txtEingabeDauerBeschäftigung.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeDauerBeschäftigung.TabIndex = 1;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(94, 79);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(192, 34);
            this.btnBerechnen.TabIndex = 2;
            this.btnBerechnen.Text = "Prämie berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // txtAusgabePrämie
            // 
            this.txtAusgabePrämie.Location = new System.Drawing.Point(247, 119);
            this.txtAusgabePrämie.Name = "txtAusgabePrämie";
            this.txtAusgabePrämie.ReadOnly = true;
            this.txtAusgabePrämie.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabePrämie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sie erhalten eine Prämie in Höhe von:";
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(193, 148);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(192, 34);
            this.btnSchließen.TabIndex = 5;
            this.btnSchließen.Text = "Anwendung schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 189);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.txtAusgabePrämie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtEingabeDauerBeschäftigung);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S 45, A2 Prämierechner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSchließen;

        private System.Windows.Forms.TextBox txtAusgabePrämie;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnBerechnen;

        private System.Windows.Forms.TextBox txtEingabeDauerBeschäftigung;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}