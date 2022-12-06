using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_HB_SwitchQuartale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnTxTQuartal_Click(object sender, EventArgs e)
        {
            // Try & catch funktion
            try
            {

                // Variabeln Initalisieren und Deklarieren
                string monatEingabe = txtMonat.Text;

                string quartal;

                string jaBisMä = "1. Quartal";
                string apBisJun = "2. Quartal";
                string juliBisSep = "3. Quartal";
                string okBisDez = "4. Quartal";
                string txtDefault = "Monat eingeben";


                // Switch cases um verschatelte Selektion zu ersparren 
                switch (monatEingabe)
                {
                    case "Januar":
                    case "Februar":
                    case "März":
                        quartal = jaBisMä;
                        break;
                    case "April":
                    case "Mai":
                    case "Juni":
                        quartal = apBisJun;
                        break;
                    case "Juli":
                    case "August":
                    case "September":
                        quartal = juliBisSep;
                        break;
                    case "Oktober":
                    case "November":
                    case "Dezember":
                        quartal = okBisDez;
                        break;
                    default:
                        quartal = txtDefault;
                        break;
                }

                // Die werte ausgeben
                txtQuartalTxtAusgabe.Text = quartal;
            }
            catch
            {
                // Fehler abfangen und in einer Messagebox ausgeben
                MessageBox.Show("Bitte geben sie Ausgschriebene Monate an!");
            }
        }

        private void btnQuartalCbm_Click(object sender, EventArgs e)
        {
            // Wird aus der Combobox ausgelesen
            string monat = cmbMonat.Text;

            string quartal;

            string jaBisMä = "1. Quartal";
            string apBisJun = "2. Quartal";
            string juliBisSep = "3. Quartal";
            string okBisDez = "4. Quartal";
            string txtDefault = "Monat eingeben";


            // Switch cases um verschatelte Selektion zu ersparren 
            switch (monat)
            {
                case "Januar":
                case "Februar":
                case "März":
                    quartal = jaBisMä;
                    break;
                case "April":
                case "Mai":
                case "Juni":
                    quartal = apBisJun;
                    break;
                case "Juli":
                case "August":
                case "September":
                    quartal = juliBisSep;
                    break;
                case "Oktober":
                case "November":
                case "Dezember":
                    quartal = okBisDez;
                    break;
                default:
                    quartal = txtDefault;
                    break;
            }

            // Die werte ausgeben
            txtCmQuartal.Text = quartal;

        }

        // Aufgabenstellung 2

        // Durch Doppelklick auf das Formular (eine Stelle an der kein Steuerelemnt liegt) wird ein Form_Load Ereigniss erstellt
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            // Den Werten der Combox werden von C# automatusch Indizes zugeteilt. Der Index für den Ersten wert liegt bei 0
            cmbMonat.Items.Add("Bitte treffen Sie eine Auswahl"); // Index 0
            cmbMonat.Items.Add("Januar"); // Index 1
            cmbMonat.Items.Add("Februar"); // Index 2
            cmbMonat.Items.Add("März"); // Index 3
            cmbMonat.Items.Add("Mai"); // etc.
            cmbMonat.Items.Add("Juni");
            cmbMonat.Items.Add("Juli");
            cmbMonat.Items.Add("August");
            cmbMonat.Items.Add("September");
            cmbMonat.Items.Add("Oktober");
            cmbMonat.Items.Add("November");
            cmbMonat.Items.Add("Dezember");

            // Über den Index wird eine Vorauswahl getroffen, die in der COmbox beim programmstart angezeigt wird
            cmbMonat.SelectedIndex = 0;
        }
    }
}
