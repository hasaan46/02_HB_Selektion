using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_10_ÜbungZinsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Variabeln Deklarieren und Initialisieren
                const double bis10000 = 0.02;
                const double bis50000 = 0.025;
                const double über50000 = 0.0275;
                const double anlageFür2Jahre = 0.0025;
                double eingabeAnlageBetrag = Convert.ToDouble(txtEingabeEuro.Text);
                
                
                double gesamtBetrag = 0;
                double zinsZahlung = 0;
                double zinsSatz = 0;

                // Berechnug der Werte und if und else abfragen
                if (eingabeAnlageBetrag < 10000)
                {
                    zinsSatz = bis10000;
                }
                else
                {
                    if (eingabeAnlageBetrag < 50000)
                    {
                        zinsSatz = bis50000;
                    }
                    else
                    {
                        zinsSatz = über50000;
                    }
                }

                if (rBtnAnlage.Checked)
                {
                    zinsSatz += anlageFür2Jahre;
                }

                zinsZahlung = eingabeAnlageBetrag * zinsSatz;
                gesamtBetrag = zinsZahlung + eingabeAnlageBetrag;

                // Ausgabe aller Werte

                txtAusgabeJahr.Text = zinsZahlung.ToString("0.00" + "€");
                if (chkGesamt.Checked)
                {
                    MessageBox.Show("Der gesamtbetrag beträgt:" +
                                    gesamtBetrag.ToString("0.00" + "€"));
                }
            }
            // Catch zum Fehler abfangen und ausgeben
            catch (OverflowException)
            {
                MessageBox.Show("Bitte geben sie eine zahl ein");
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben sie eine kleinere zahl ein");
            }
        }
    }
}