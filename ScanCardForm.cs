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

                    // zisti platnost karty
                    DateTime today = DateTime.Today;
                    DateTime timeOfRegistration = DateTime.Parse(temp[3]);

                    //ak rozdiel medzi dnesnym a registracny mesiacom je mensi rovny poctu zaplatenych mesiacov
                    //a ak je dnesny den mensi rovny registracnemu dnu tak je vsetko ok. Inak karta vyprsala.
                    if (Math.Abs(timeOfRegistration.Month - today.Month) <= int.Parse(temp[2]) 
                        && today.Day < timeOfRegistration.Day)
                    {
                        labelIsValid.Text = "Valid!";
                    }
                    else
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
