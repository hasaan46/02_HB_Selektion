using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_HB_SwitchNoten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // Durch Doppelklick auf die Textbox wird standartmäßig ein TextChanged-Ereignis erzeugt
        // Das bedeutet sobald ein neuer/veränderter´Text in die Textbox eingegbeben wird
        // Wird der code unten ausgeführt
        private void txtNoteNum_TextChanged(object sender, EventArgs e)
        {
            // Try funktion zum testen des codes und im nachhinein catchen um fehler abzufangen bevor das programm crasht
            try
            {
                // Deklarieren und Initalisieren von der Note
                int note = Convert.ToInt16(txtNoteNum.Text);

                // String für die Texte um auszugeben
                string notenText;

                // Konstanten um diese unten zu verwenden
                const string text1 = "sehr gut";
                const string text2 = "gut";
                const string text3 = "befriedigend";
                const string text4 = "ausreichend";
                const string text5 = "mangelhaft";
                const string text6 = "ungenügend";
                const string text0 = "s. B.";
                const string textDefault = "unzulässige Note";


                // Switch funktion um mehrere möglichkeiten auszugeben und diese zu speichern
                // Damit eine Starke verschachtlung erspart wird
                switch (note)
                {
                    // Es werden verschiedene möglichkeiten getestet damit wir diese Später ausgeben können
                    // z.B. 1 wird der Text "sehr gut" ausgegeben
                    case 1:
                        notenText = text1;
                        break; // War die überprüfung zutreffend (der Wert = 1)
                        // Wird die weitere überprüfung abgebrochen, da sie nicht mehr erforderlich ist
                    case 2:
                        notenText = text2;
                        break;
                    case 3:
                        notenText = text3;
                        break;
                    case 4:
                        notenText = text4;
                        break;
                    case 5:
                        notenText = text5;
                        break;
                    case 6:
                        notenText = text6;
                        break;
                    case 0:
                        notenText = text0;
                        break;
                    default: // War keiner der Fälle zutreffend so wird der Text "Unzulässig" ausgegeben
                        notenText = textDefault;
                        break;
                }
                // Ausgabe der Werte
                txtNoteAusge.Text = notenText.ToString();
            }
            // Abfangen der Fehler und diese in einer MessageBox ausgeben
            catch
            {
                MessageBox.Show("Bitte geben sie eine Zahl ein!");
            }
        }
    }
}
