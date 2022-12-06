using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_HB_S38_Angebot
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
            // Code versuchen und Ausführen
            try
            {
                // Constanten
                const double zimmerPreis = 70;
                const double extra = 20;
                const double mwSt = 19;

                // Initalieren und Deklarieren variabeln
                int personenAnzahl = Convert.ToInt16(txtEingabePersonen.Text);
                int tageEingabe = Convert.ToInt16(txtEingabeAufenthaltsdauer.Text);
                double nettoPreis;
                double bruttoPreis;

                // Berechnen
                nettoPreis = zimmerPreis * tageEingabe * personenAnzahl;

                if (tageEingabe == 1)
                    nettoPreis = nettoPreis + extra;
                bruttoPreis = nettoPreis + nettoPreis * mwSt / 100;

                txtAusgabeBrutto.Text = bruttoPreis.ToString("0.00" + " €");
                txtAusgabeNetto.Text = nettoPreis.ToString("0.00" + " €");
            }
            // Fehler catchen (Overflow und Format)
            catch (OverflowException)
            {
                // Fehler zeigen
                MessageBox.Show("Bitte geben sie niedriegere Zahlenwerte ein!");
            }
            catch (FormatException)
            {
                // Fehler zeigen
                MessageBox.Show("Bitte geben sie nur Zahlenwerte ein!");
            }
        }
    }
}
