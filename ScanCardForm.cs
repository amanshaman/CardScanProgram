using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CardScanProgram
{
    public partial class ScanCardForm : Form
    {
        public ScanCardForm()
        {
            InitializeComponent();
            textBoxScannedCode.Focus();
        }

        private void textBoxScannedCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //porovnaj s datami v subore.
                CustomerControl customer = new CustomerControl();
                string[] temp = customer.SearchRecord(textBoxScannedCode.Text);
                if (temp != null)
                {
                    textBoxNamAndSurname.Text = temp[1];
                    textBoxDate.Text = temp[3];
                    labelIsValid.Text = "Valid!";

                    // zisti platnost karty                    
                    DateTime timeOfRegistration = DateTime.Parse(temp[3]);
                    string months = temp[2].Split(' ')[0];

                    DateTime expirationDate = timeOfRegistration.AddMonths(int.Parse(months));

                    int result = DateTime.Compare(expirationDate, DateTime.Today);

                    //-1 = expirovalo
                    //0 - dnes expiruje ale je platna
                    //1 - este je platna
                    if (result == 1 || result == 0)
                    {
                        labelIsValid.Text = "Valid!";
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Platnosť karty vypršala.");
                        labelIsValid.Text = "Invalid!";
                    }
                }
                else
                {
                    MessageBox.Show("Nenašiel sa zákaznik.");
                    labelIsValid.Text = "Invalid!";
                }
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

        private void ScanCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Form1Instance.Show();
        }
    }
}
