using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_09_S45A2_Prämie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Konstanten deklarieren
                const int prämieUnterDreiJ = 0;
                const int prämieUnterZehnJ = 150;
                const int grenzeUnten = 3;
                const int grenzeOben = 10;
                const int faktor10 = 10;

                // Nutzereingabe in Variable speichern
                int dauer = Convert.ToInt16(txtEingabeDauerBeschäftigung.Text);

                // Variablen für die Berechnung deklarieren
                int prämie;
                
                // Prämie für mehr als 10 jahre deklarieren und berechnen
                int prämieAbZehnJ = prämieUnterZehnJ + (faktor10 * dauer);

                // Zuweisung der Werte mit verschachtelter Selektion
                if(dauer < grenzeUnten)
                {
                    prämie = prämieUnterDreiJ;
                }
                else
                {
                    if(dauer < grenzeOben)
                    {
                        prämie = prämieUnterZehnJ;
                    }
                    else
                    {
                        prämie = prämieAbZehnJ;
                    }

                    // Ausgabe der Prämie
                    txtAusgabePrämie.Text = prämie.ToString();
                }
            }
            catch
            {
                // Fehler abfangen und in einer MessageBox ausgeben
                MessageBox.Show("Bitte geben Sie die Dauer Ihrer Beschäftigung in Jahren ein!");
            }
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            // Anwendung schließen
            Close();
        }
    }
}