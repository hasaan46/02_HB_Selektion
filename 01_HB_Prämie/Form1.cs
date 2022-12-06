using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HB_Prämie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Try
            try
            {
                // Deklarieren und Initalisieren
                const double Prämie = 0.015;
                const double Extra = Prämie + 0.005;

                double jahresUmsatz = Convert.ToDouble(txtBoxUmsatz.Text);
                double PrämieEnde;

                // Berechnen
                PrämieEnde = jahresUmsatz * Prämie;

                // If berechnen
                if (jahresUmsatz > 100000)
                {
                    PrämieEnde = jahresUmsatz * Extra;
                }

                txtBoxPreamie.Text = PrämieEnde.ToString("0.00" + " €");
            }
            // Catchen
            catch (FormatException)
            {
                // Fehler abfangen
                MessageBox.Show("Bitte geben sie gültige Zahlenwerte ein!", "Ein fehler ist aufgetreten!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Von ihnen angebene Zahl ist zu groß!", "Ein fehler ist aufgetreten!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
