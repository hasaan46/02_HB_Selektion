using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_HB_S42A1_Schrauben
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
                // Variabeln initialiseren und Deklarieren
                int schrauben = Convert.ToInt32(txtEingabeStück.Text);

                // Constante
                double Preis = 0.20;
                double Rabatt = 0.05;
                double Versand = 5;
                double gesamtPreis;
                double listenpreis;

                // Berechnen und IF und Else berechnungen
                // Wenn über 1000
                if(schrauben > 1000)
                {
                    listenpreis = schrauben * Preis;
                    gesamtPreis = listenpreis;
                    Rabatt = gesamtPreis * Rabatt;
                    Versand = 0;
                    gesamtPreis = gesamtPreis - Rabatt;
                    txtAusgabeRabatt.Text = Math.Round(Rabatt, 0).ToString();
                }
                // Wenn unter 1000
                else
                {
                    listenpreis = schrauben * Preis;
                    gesamtPreis = listenpreis + Versand;
                    txtAusgabeRabatt.Text = "0";
                }
                txtAusgabeGesamt.Text = Math.Round(gesamtPreis, 0).ToString();
                txtAusgabeListen.Text = Math.Round(listenpreis, 0).ToString();
                txtAusgabeVersand.Text = Versand.ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Anwendung beenden
            Close();
        }
    }
}
