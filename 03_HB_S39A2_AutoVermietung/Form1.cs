using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_HB_S39A2_AutoVermietung
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
            // Versuchen des Codes
            try
            {
                // Constanten definieren
                const double mwSt = 0.19;
                const double normTarif = 68;
                const double preisKM = 0.65;

                // Variabeln initialiseren und Deklarieren
                double Kilometer = Convert.ToDouble(txtEingabeKm.Text);
                double betragNetto;
                double mwStEuro;
                double betragBrutto;

                // Berechnen und IF
                betragNetto = normTarif;
                if (Kilometer > 200)
                    betragNetto = normTarif + (Kilometer - 200) * preisKM;

                mwStEuro = betragNetto * mwSt;
                betragBrutto = betragNetto + mwStEuro;

                // Ausgeben
                txtAusgabeBrutto.Text = betragBrutto.ToString("0.00" + " €");
                txtAusgabeNetto.Text = betragNetto.ToString("0.00" + " €");
                txtAusgabeMwSt.Text = mwStEuro.ToString("0.00" + " €");
            }
            // Alle fehler abfangen (overFlow und Format)
            catch (OverflowException)
            {
                // Fehler anzeigencatch (OverflowException)     
                MessageBox.Show("Bitte geben sie niedriegere Zahlenwerte ein!");
            }            
            catch (FormatException)
            {
                // Fehler anzeigencatch (FormatException)     
                MessageBox.Show("Bitte geben sie nur Zahlenwerte ein!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
