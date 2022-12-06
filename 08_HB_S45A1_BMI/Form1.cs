using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_HB_S45A1_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {
            // Versuchen des Codes und später catchen um die fehler abzufangen die auftretten werden
            try
            {
                // Variabeln deklarieren und initalisieren und auch Konstanten wählen
                const double unterGewicht = 18.5;
                const double überGewicht = 25;

                double größeCM = Convert.ToDouble(txtEingabeCm.Text);
                double gewichtKG = Convert.ToDouble(txtEingabeKg.Text);
                double meter = größeCM / 100;
                string txtUntergewicht = "Sie sind im Untergewicht";
                string txtÜbergewicht = "Sie sind im Übergewicht";
                string txtNormal = "Sie sind im Normalgewicht";

                double bmi;
                string wert;

                // Berechnung des BMIs
                bmi = gewichtKG / (Math.Pow(meter, 2));

                // Wenn BMI unter 18.5
                if (bmi < unterGewicht)
                {
                    wert = txtUntergewicht;
                }
                else
                {
                    // Wenn BMI über 25
                    if (bmi > überGewicht)
                    {
                        wert = txtÜbergewicht;
                    }
                    // Wenn BMI normal
                    else
                    {
                        wert = txtNormal;
                    }
                }
                // Alle werte ausgeben und runden
                txtAusgabeBMI.Text = Math.Round(bmi, 2).ToString("0.00");
                txtAusgabeBMIWert.Text = wert;
            }
            // Abfangen aller Fehler (FormatExeption und Overflow)
            catch (OverflowException)
            {
                // Fehler im neuen fenster anzeigen
                MessageBox.Show("Die von ihnen angebene Zahl ist zu groß!");
            }
            catch (FormatException)
            {
                // Fehler im neuen fenster anzeigen
                MessageBox.Show("Bitte geben sie nur Zahlenwerte ein!");
            }
        }
    }
}
