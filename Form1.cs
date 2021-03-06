﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CardScanProgram
{
    public partial class Form1 : Form
    {
        public static Form1 Form1Instance;
        public Form1()
        {
            InitializeComponent();
            Form1Instance = this;
        }

        private void buttonCreateCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCardForm newCard = new NewCardForm();
            newCard.Show();
        }

        private void buttonScanCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanCardForm scanCard = new ScanCardForm();
            scanCard.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanSeasonTicketForm scanSeasonTicketForm = new ScanSeasonTicketForm(false);
            scanSeasonTicketForm.Show();
        }

        private void btnCardsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanSeasonTicketForm scanSeasonTicketForm = new ScanSeasonTicketForm(true);
            scanSeasonTicketForm.Show();
        }
    }
}
