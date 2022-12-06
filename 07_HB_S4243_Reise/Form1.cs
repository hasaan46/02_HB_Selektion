using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_HB_S4243_Reise
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
            // Code versuchen
            try
            {

                // Constante
                // Deklarieren und Initalisieren aller Variabeln
                const double nullbisSechs = 1;
                const double siebenbisElf = 0.7;
                const double sonst = 0.3;
                const double zimmer = 50;
                const int personen = 2;
                const double mwSt = 0.19;
                const double dauer = 7;
                const double grenzeBaby = 7;
                const double grenzeKind = 11;
                const int hundertProzent = 1;

                double rabatt;

                int EingabeKindalter = Convert.ToInt32(txtEingabeKind.Text);
                double ausgabeNetto2Erw;
                double ausgabeNetto1Kind;
                double ausgabeNetto2Erw1Kind;
                double ausgabeBrutto2Erw;

                // Verschachtelte zuweisung

                if (EingabeKindalter < grenzeBaby)
                {
                    rabatt = nullbisSechs;
                }
                else
                {
                    if(EingabeKindalter <= grenzeKind)
                    {
                        rabatt = siebenbisElf;
                    }
                    else
                    {
                        rabatt = sonst;
                    }
                }

                // Werte berechnen
                ausgabeNetto2Erw = zimmer * personen * dauer;
                ausgabeNetto1Kind = zimmer * (hundertProzent - rabatt) * dauer;
                ausgabeNetto2Erw1Kind = ausgabeNetto2Erw + ausgabeNetto1Kind;
                ausgabeBrutto2Erw = ausgabeNetto2Erw1Kind * (hundertProzent + mwSt);

                // Werte ausgeben
                txtAusgabeBrutto2Erwachsene.Text = ausgabeBrutto2Erw.ToString("0.00" + " €");
                txtAusgabeNetto2Erw.Text = ausgabeNetto2Erw.ToString("0.00" + " €");
                txtAusgabeNetto2Erwachsene.Text = ausgabeNetto2Erw1Kind.ToString("0.00" + " €");
                txtAusgabeNettoKind.Text = ausgabeNetto1Kind.ToString("0.00" + " €");

            }
            // Alle möglichen fehler abfangen
            catch (FormatException)
            {
                MessageBox.Show("Geben sie bitte nur Zahlen ein!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Geben sie bitte nur richtige Zahlenwerte ein!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Programm schließen
            Close();
        }
    }
}
