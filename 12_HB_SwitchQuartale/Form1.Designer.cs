
namespace _12_HB_SwitchQuartale
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
            this.txtMonat = new System.Windows.Forms.TextBox();
            this.btnTxTQuartal = new System.Windows.Forms.Button();
            this.txtQuartalTxtAusgabe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMonat = new System.Windows.Forms.ComboBox();
            this.txtCmQuartal = new System.Windows.Forms.TextBox();
            this.btnQuartalCbm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aufgabenstellung 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geben Sie den Monat ein:";
            // 
            // txtMonat
            // 
            this.txtMonat.Location = new System.Drawing.Point(150, 55);
            this.txtMonat.Name = "txtMonat";
            this.txtMonat.Size = new System.Drawing.Size(100, 20);
            this.txtMonat.TabIndex = 2;
            // 
            // btnTxTQuartal
            // 
            this.btnTxTQuartal.Location = new System.Drawing.Point(272, 55);
            this.btnTxTQuartal.Name = "btnTxTQuartal";
            this.btnTxTQuartal.Size = new System.Drawing.Size(105, 23);
            this.btnTxTQuartal.TabIndex = 3;
            this.btnTxTQuartal.Text = "Quartal anzeigen";
            this.btnTxTQuartal.UseVisualStyleBackColor = true;
            this.btnTxTQuartal.Click += new System.EventHandler(this.btnTxTQuartal_Click);
            // 
            // txtQuartalTxtAusgabe
            // 
            this.txtQuartalTxtAusgabe.Location = new System.Drawing.Point(402, 57);
            this.txtQuartalTxtAusgabe.Name = "txtQuartalTxtAusgabe";
            this.txtQuartalTxtAusgabe.ReadOnly = true;
            this.txtQuartalTxtAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtQuartalTxtAusgabe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aufgabenstellung 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wählen sie ein Monat:";
            // 
            // cmbMonat
            // 
            this.cmbMonat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonat.FormattingEnabled = true;
            this.cmbMonat.Location = new System.Drawing.Point(132, 144);
            this.cmbMonat.Name = "cmbMonat";
            this.cmbMonat.Size = new System.Drawing.Size(121, 21);
            this.cmbMonat.TabIndex = 7;
            // 
            // txtCmQuartal
            // 
            this.txtCmQuartal.Location = new System.Drawing.Point(402, 144);
            this.txtCmQuartal.Name = "txtCmQuartal";
            this.txtCmQuartal.ReadOnly = true;
            this.txtCmQuartal.Size = new System.Drawing.Size(100, 20);
            this.txtCmQuartal.TabIndex = 9;
            // 
            // btnQuartalCbm
            // 
            this.btnQuartalCbm.Location = new System.Drawing.Point(272, 142);
            this.btnQuartalCbm.Name = "btnQuartalCbm";
            this.btnQuartalCbm.Size = new System.Drawing.Size(105, 23);
            this.btnQuartalCbm.TabIndex = 8;
            this.btnQuartalCbm.Text = "Quartal anzeigen";
            this.btnQuartalCbm.UseVisualStyleBackColor = true;
            this.btnQuartalCbm.Click += new System.EventHandler(this.btnQuartalCbm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 236);
            this.Controls.Add(this.txtCmQuartal);
            this.Controls.Add(this.btnQuartalCbm);
            this.Controls.Add(this.cmbMonat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuartalTxtAusgabe);
            this.Controls.Add(this.btnTxTQuartal);
            this.Controls.Add(this.txtMonat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monat - Quartal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonat;
        private System.Windows.Forms.Button btnTxTQuartal;
        private System.Windows.Forms.TextBox txtQuartalTxtAusgabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMonat;
        private System.Windows.Forms.TextBox txtCmQuartal;
        private System.Windows.Forms.Button btnQuartalCbm;
    }
}

