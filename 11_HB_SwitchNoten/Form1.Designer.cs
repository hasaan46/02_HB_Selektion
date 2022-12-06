
namespace _11_HB_SwitchNoten
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoteNum = new System.Windows.Forms.TextBox();
            this.txtNoteAusge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numerische Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ausgeschriebene Note:";
            // 
            // txtNoteNum
            // 
            this.txtNoteNum.AcceptsReturn = true;
            this.txtNoteNum.Location = new System.Drawing.Point(108, 30);
            this.txtNoteNum.Name = "txtNoteNum";
            this.txtNoteNum.Size = new System.Drawing.Size(100, 20);
            this.txtNoteNum.TabIndex = 2;
            this.txtNoteNum.TextChanged += new System.EventHandler(this.txtNoteNum_TextChanged);
            // 
            // txtNoteAusge
            // 
            this.txtNoteAusge.Location = new System.Drawing.Point(135, 74);
            this.txtNoteAusge.Name = "txtNoteAusge";
            this.txtNoteAusge.ReadOnly = true;
            this.txtNoteAusge.Size = new System.Drawing.Size(100, 20);
            this.txtNoteAusge.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 136);
            this.Controls.Add(this.txtNoteAusge);
            this.Controls.Add(this.txtNoteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Noten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoteNum;
        private System.Windows.Forms.TextBox txtNoteAusge;
    }
}

