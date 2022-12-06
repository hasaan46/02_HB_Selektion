using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_HB_RadioButtonCheckBoxen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAbsenden_Click(object sender, EventArgs e)
        {
                // Ausgabetext für Variaeln
                // Deklarieren
                const string txtMännlich = "Männlich kentnisse in";
                const string txtWeiblich = "Weiblich kentnisse in";
                const string txtCplus = ", C++";
                const string txtCsharp = ", C#";
                const string txtJava = ", Java";

                string ausgabeText;

                if (rBtnMännlich.Checked)
                {
                    ausgabeText = txtMännlich;
                }
                else
                {
                    ausgabeText = txtWeiblich;
                }

                if (chkCplus.Checked)
                {
                    // += Als Zuweisungoperator addiert den textCplus
                    // zu dem bereits vorhanden ausgabeText
                    // entspricht: ausgabetext = ausgabetext + txtCplus
                    ausgabeText += txtCplus;
                }
                if (chkJava.Checked)
                {
                    // += Als Zuweisungoperator addiert den textCplus
                    // zu dem bereits vorhanden ausgabeText
                    // entspricht: ausgabetext = ausgabetext + txtCplus
                    ausgabeText += txtJava;
                }
                if (chkCsharp.Checked)
                {
                    // += Als Zuweisungoperator addiert den textCplus
                    // zu dem bereits vorhanden ausgabeText
                    // entspricht: ausgabetext = ausgabetext + txtCplus
                    ausgabeText += txtCsharp;
                }
                MessageBox.Show(ausgabeText);
        }
    }
}
