using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                }
                else
                {
                    MessageBox.Show("Nenašiel sa zákaznik.");
                    labelIsValid.Text = "Invalid!";
                }

                // zisti platnost karty
                DateTime today = DateTime.Today;
                DateTime timeOfRegistration = DateTime.Parse(temp[3]);
                //rozdiel v datumoch podla dni musi byt mensi ako typ karty(v mesiacoch) * 30 dni (pocet dni v mesiaci?)
                if ((today - timeOfRegistration).TotalDays < int.Parse(temp[2]) * 30)
                {
                    labelIsValid.Text = "Valid!";
                }
                else
                {
                    MessageBox.Show("Platnosť karty vypršala.");
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
