
namespace _06_HB_RadioButtonCheckBoxen
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
            this.rBtnMännlich = new System.Windows.Forms.RadioButton();
            this.rBtnWeiblich = new System.Windows.Forms.RadioButton();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkCplus = new System.Windows.Forms.CheckBox();
            this.btnAbsenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fragebogen";
            // 
            // rBtnMännlich
            // 
            this.rBtnMännlich.AutoSize = true;
            this.rBtnMännlich.Checked = true;
            this.rBtnMännlich.Location = new System.Drawing.Point(15, 83);
            this.rBtnMännlich.Name = "rBtnMännlich";
            this.rBtnMännlich.Size = new System.Drawing.Size(68, 17);
            this.rBtnMännlich.TabIndex = 1;
            this.rBtnMännlich.TabStop = true;
            this.rBtnMännlich.Text = "Männlich";
            this.rBtnMännlich.UseVisualStyleBackColor = true;
            // 
            // rBtnWeiblich
            // 
            this.rBtnWeiblich.AutoSize = true;
            this.rBtnWeiblich.Location = new System.Drawing.Point(15, 123);
            this.rBtnWeiblich.Name = "rBtnWeiblich";
            this.rBtnWeiblich.Size = new System.Drawing.Size(66, 17);
            this.rBtnWeiblich.TabIndex = 2;
            this.rBtnWeiblich.Text = "Weiblich";
            this.rBtnWeiblich.UseVisualStyleBackColor = true;
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Location = new System.Drawing.Point(172, 84);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(101, 17);
            this.chkCsharp.TabIndex = 3;
            this.chkCsharp.Text = "C# - Kenntnisse";
            this.chkCsharp.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(172, 160);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(104, 17);
            this.chkJava.TabIndex = 4;
            this.chkJava.Text = "Java - Kentnisse";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkCplus
            // 
            this.chkCplus.AutoSize = true;
            this.chkCplus.Location = new System.Drawing.Point(172, 123);
            this.chkCplus.Name = "chkCplus";
            this.chkCplus.Size = new System.Drawing.Size(100, 17);
            this.chkCplus.TabIndex = 5;
            this.chkCplus.Text = "C++ - Kentnisse";
            this.chkCplus.UseVisualStyleBackColor = true;
            // 
            // btnAbsenden
            // 
            this.btnAbsenden.Location = new System.Drawing.Point(172, 200);
            this.btnAbsenden.Name = "btnAbsenden";
            this.btnAbsenden.Size = new System.Drawing.Size(100, 23);
            this.btnAbsenden.TabIndex = 6;
            this.btnAbsenden.Text = "Absenden";
            this.btnAbsenden.UseVisualStyleBackColor = true;
            this.btnAbsenden.Click += new System.EventHandler(this.btnAbsenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 248);
            this.Controls.Add(this.btnAbsenden);
            this.Controls.Add(this.chkCplus);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkCsharp);
            this.Controls.Add(this.rBtnWeiblich);
            this.Controls.Add(this.rBtnMännlich);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Radiobutton und Checkboxen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnMännlich;
        private System.Windows.Forms.RadioButton rBtnWeiblich;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkCplus;
        private System.Windows.Forms.Button btnAbsenden;
    }
}

