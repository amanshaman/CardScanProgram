using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CardScanProgram
{
    public partial class NewCardForm : Form
    {
        public NewCardForm()
        {
            InitializeComponent();
            textBoxScannedCode.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Naozaj sa chcete vrátiť? Zmeny nebudu uložené.", "Pozor!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form1.Form1Instance.Show();
            }
            else
            {
                //do nothing
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Boolean isOk = true;
            try
            {
                if (textBoxScannedCode.Text != "")
                {
                    NewCustomer.CardCode = textBoxScannedCode.Text;
                }
                else
                {
                    isOk = false;
                    MessageBox.Show("Nie je naskenovany Čiarovy kód.");
                    textBoxScannedCode.Focus();
                }

                if (dateTimePicker.Checked)
                {
                    NewCustomer.RegistrationDate = dateTimePicker.Value;
                }
                else
                {
                    isOk = false;
                    MessageBox.Show("Vyberte validný dátum.");
                    dateTimePicker.Focus();
                }

                if (textBoxNameAndSurname.Text != "")
                {
                    NewCustomer.Name = textBoxNameAndSurname.Text;
                }
                else
                {
                    isOk = false;
                    MessageBox.Show("Pole s menom zákazníka nie je vzplnené!");
                    textBoxNameAndSurname.Focus();
                }

                if (comboBoxTypeOfCard.SelectedIndex > -1)
                {
                    NewCustomer.CardType = comboBoxTypeOfCard.Text;
                }
                else
                {
                    isOk = false;
                    MessageBox.Show("Vyžaduje sa vybratie typu karty!");
                    comboBoxTypeOfCard.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (isOk)
            {
                CustomerControl customer = new CustomerControl();
                customer.AddRecord(NewCustomer.CardCode, NewCustomer.Name, NewCustomer.CardType, NewCustomer.RegistrationDate);
                this.Close();
                Form1.Form1Instance.Show();
            }            
        }

        private void NewCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Form1Instance.Show();
        }
    }
}
