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
        private Boolean manazment;
        public ScanSeasonTicketForm(Boolean entry)
        {
            manazment = entry;
            InitializeComponent();
            textBoxScannedCode.Focus();
            if (manazment)
            {
                buttonOdratat.Text = "Uložiť";
            }
            
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
            this.Dispose();
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
                    buttonOdratat.Enabled = true;
                    if (manazment)
                    {
                        comboBoxNoEntry.Enabled = true;
                    }
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
            int newNoEntries;
            if (!manazment)
            {
                if (currentNoEntries <= 0)
                {
                    MessageBox.Show("Nedostatok vstupov.");
                    return;
                }
                newNoEntries = currentNoEntries - 1;
            }
            else
            {
                newNoEntries = currentNoEntries;
            }
            comboBoxNoEntry.Text = newNoEntries.ToString();
            if (!customer.ReplaceNoEntries(textBoxScannedCode.Text, comboBoxNoEntry.Text))
            {
                MessageBox.Show("Chyba pri zmene udajov.");
            }
            
            buttonOdratat.Enabled = false;
            comboBoxNoEntry.Enabled = false;
            buttonOK.Focus();
        }
    }
}
