using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CardScanProgram
{
    public partial class ScanSeasonTicketForm : Form
    {
        public ScanSeasonTicketForm()
        {
            InitializeComponent();
            textBoxScannedCode.Focus();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Form1Instance.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Form1Instance.Show();
        }

        private void ScanSeasonTicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Form1Instance.Show();
        }
        private CustomerControl customer;
        private void textBoxScannedCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //porovnaj s datami v subore.
                customer = new CustomerControl();
                string[] temp = customer.SearchRecord(textBoxScannedCode.Text);
                if (temp != null)
                {
                    if (temp[2].Split(' ')[1] != "vstupov")
                    {
                        MessageBox.Show("Zlý typ karty! Preukázaná karta nie je vydaná na fixný počet vstupov. Skúste použiť " +
                            "tlačidlo: Kontrola časovej permanentky");
                        return;
                    }

                    textBoxNamAndSurname.Text = temp[1];
                    textBoxDate.Text = temp[3];
                    comboBoxNoEntry.Text = temp[2].Split(' ')[0];
                }
                else
                {
                    MessageBox.Show("Nenašiel sa zákaznik.");
                }
            }
        }

        private void buttonOdratat_Click(object sender, EventArgs e)
        {
            int currentNoEntries = int.Parse(comboBoxNoEntry.Text);
            if (currentNoEntries <= 0)
            {
                MessageBox.Show("Nedostatok vstupov.");
                return;
            }

            int newNoEntries = currentNoEntries - 1;
            comboBoxNoEntry.Text = newNoEntries.ToString();
            if (!customer.ReplaceNoEntries(textBoxScannedCode.Text, comboBoxNoEntry.Text))
            {
                MessageBox.Show("Chyba pri zmene udajov.");
            }
            
            buttonOdratat.Enabled = false;
            buttonOK.Focus();
        }
    }
}
