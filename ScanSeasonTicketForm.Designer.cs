namespace CardScanProgram
{
    partial class ScanSeasonTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamAndSurname = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelScannedCode = new System.Windows.Forms.Label();
            this.textBoxScannedCode = new System.Windows.Forms.TextBox();
            this.buttonOdratat = new System.Windows.Forms.Button();
            this.comboBoxNoEntry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dátum vydania: ";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(227, 104);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(350, 20);
            this.textBoxDate.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Meno a priezvisko:";
            // 
            // textBoxNamAndSurname
            // 
            this.textBoxNamAndSurname.Enabled = false;
            this.textBoxNamAndSurname.Location = new System.Drawing.Point(227, 67);
            this.textBoxNamAndSurname.Name = "textBoxNamAndSurname";
            this.textBoxNamAndSurname.Size = new System.Drawing.Size(350, 20);
            this.textBoxNamAndSurname.TabIndex = 23;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(502, 196);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "späť";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(421, 196);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelScannedCode
            // 
            this.labelScannedCode.AutoSize = true;
            this.labelScannedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScannedCode.Location = new System.Drawing.Point(25, 27);
            this.labelScannedCode.Name = "labelScannedCode";
            this.labelScannedCode.Size = new System.Drawing.Size(196, 25);
            this.labelScannedCode.TabIndex = 20;
            this.labelScannedCode.Text = "Naskenovany kód: ";
            // 
            // textBoxScannedCode
            // 
            this.textBoxScannedCode.Location = new System.Drawing.Point(227, 32);
            this.textBoxScannedCode.Name = "textBoxScannedCode";
            this.textBoxScannedCode.Size = new System.Drawing.Size(350, 20);
            this.textBoxScannedCode.TabIndex = 19;
            this.textBoxScannedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxScannedCode_KeyDown);
            // 
            // buttonOdratat
            // 
            this.buttonOdratat.Location = new System.Drawing.Point(238, 169);
            this.buttonOdratat.Name = "buttonOdratat";
            this.buttonOdratat.Size = new System.Drawing.Size(75, 23);
            this.buttonOdratat.TabIndex = 31;
            this.buttonOdratat.Text = "Odrátať";
            this.buttonOdratat.UseVisualStyleBackColor = true;
            this.buttonOdratat.Click += new System.EventHandler(this.buttonOdratat_Click);
            // 
            // comboBoxNoEntry
            // 
            this.comboBoxNoEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoEntry.FormattingEnabled = true;
            this.comboBoxNoEntry.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxNoEntry.Location = new System.Drawing.Point(314, 139);
            this.comboBoxNoEntry.Name = "comboBoxNoEntry";
            this.comboBoxNoEntry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoEntry.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pocet ostávajúcich vstupov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Odrátať jeden vstup:";
            // 
            // ScanSeasonTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOdratat);
            this.Controls.Add(this.comboBoxNoEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNamAndSurname);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelScannedCode);
            this.Controls.Add(this.textBoxScannedCode);
            this.Name = "ScanSeasonTicketForm";
            this.Text = "ScanSeasonTicketForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanSeasonTicketForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamAndSurname;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelScannedCode;
        private System.Windows.Forms.TextBox textBoxScannedCode;
        private System.Windows.Forms.Button buttonOdratat;
        private System.Windows.Forms.ComboBox comboBoxNoEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}