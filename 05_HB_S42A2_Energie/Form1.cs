using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_HB_S42A2_Energie
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
            // Try und Catchen
            try
            {
                // Initialisieren und Deklarieren
                double gesamtVerbrauch = Convert.ToDouble(txtEingabeliter.Text);
                int Personen = Convert.ToInt32(txtEingabePersonen.Text);
                double wohnFläche = Convert.ToDouble(txtEingabeWohnfläche.Text);
                double verbrauchkWh;
                double tatsächlicherVerbrauch;
                double Kennzahl;
                string Hinweis;

                // Berechnen und If
                // Radio button yes
                if (rBtnYes.Checked == true)
                {
                    verbrauchkWh = gesamtVerbrauch * 10;
                    tatsächlicherVerbrauch = verbrauchkWh - (Personen * 1000);
                    Kennzahl = tatsächlicherVerbrauch / wohnFläche;
                    Hinweis = "Ihr Haus hat einen guten themischen Wert!";
                }
                // Radio button no
                else
                {
                    verbrauchkWh = gesamtVerbrauch * 10;
                    tatsächlicherVerbrauch = verbrauchkWh;
                    Kennzahl = tatsächlicherVerbrauch / wohnFläche;
                    Hinweis = "Sie sollten über eine Sanierung nachdenken!";
                }
                // Texte ausgeben
                txtAusgabekWh.Text = verbrauchkWh.ToString();
                txtAusgabeVerbrauch.Text = tatsächlicherVerbrauch.ToString();
                txtAusgabekennzahl.Text = Math.Round(Kennzahl, 0).ToString();
                txtAusgabeHinweis.Text = Hinweis;
            }
            // Fehler abfangen (Overflow und Format
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
    }
}
