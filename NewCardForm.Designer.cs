﻿namespace CardScanProgram
{
    partial class NewCardForm
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
            this.textBoxScannedCode = new System.Windows.Forms.TextBox();
            this.labelScannedCode = new System.Windows.Forms.Label();
            this.labelDateOfCreation = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelNameAndSurname = new System.Windows.Forms.Label();
            this.textBoxNameAndSurname = new System.Windows.Forms.TextBox();
            this.labelTypeOfCard = new System.Windows.Forms.Label();
            this.comboBoxTypeOfCard = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxScannedCode
            // 
            this.textBoxScannedCode.Location = new System.Drawing.Point(229, 31);
            this.textBoxScannedCode.Name = "textBoxScannedCode";
            this.textBoxScannedCode.Size = new System.Drawing.Size(350, 20);
            this.textBoxScannedCode.TabIndex = 0;
            // 
            // labelScannedCode
            // 
            this.labelScannedCode.AutoSize = true;
            this.labelScannedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScannedCode.Location = new System.Drawing.Point(17, 26);
            this.labelScannedCode.Name = "labelScannedCode";
            this.labelScannedCode.Size = new System.Drawing.Size(196, 25);
            this.labelScannedCode.TabIndex = 1;
            this.labelScannedCode.Text = "Naskenovany kód: ";
            // 
            // labelDateOfCreation
            // 
            this.labelDateOfCreation.AutoSize = true;
            this.labelDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfCreation.Location = new System.Drawing.Point(17, 52);
            this.labelDateOfCreation.Name = "labelDateOfCreation";
            this.labelDateOfCreation.Size = new System.Drawing.Size(191, 25);
            this.labelDateOfCreation.TabIndex = 3;
            this.labelDateOfCreation.Text = "Datum vytvorenia: ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(229, 58);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // labelNameAndSurname
            // 
            this.labelNameAndSurname.AutoSize = true;
            this.labelNameAndSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameAndSurname.Location = new System.Drawing.Point(17, 78);
            this.labelNameAndSurname.Name = "labelNameAndSurname";
            this.labelNameAndSurname.Size = new System.Drawing.Size(193, 25);
            this.labelNameAndSurname.TabIndex = 6;
            this.labelNameAndSurname.Text = "Meno a priezvisko:";
            // 
            // textBoxNameAndSurname
            // 
            this.textBoxNameAndSurname.Location = new System.Drawing.Point(229, 84);
            this.textBoxNameAndSurname.Name = "textBoxNameAndSurname";
            this.textBoxNameAndSurname.Size = new System.Drawing.Size(350, 20);
            this.textBoxNameAndSurname.TabIndex = 5;
            // 
            // labelTypeOfCard
            // 
            this.labelTypeOfCard.AutoSize = true;
            this.labelTypeOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeOfCard.Location = new System.Drawing.Point(17, 103);
            this.labelTypeOfCard.Name = "labelTypeOfCard";
            this.labelTypeOfCard.Size = new System.Drawing.Size(113, 25);
            this.labelTypeOfCard.TabIndex = 7;
            this.labelTypeOfCard.Text = "Typ karty: ";
            // 
            // comboBoxTypeOfCard
            // 
            this.comboBoxTypeOfCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfCard.FormattingEnabled = true;
            this.comboBoxTypeOfCard.Items.AddRange(new object[] {
            "1 mesačný",
            "3 mesačný",
            "6 mesačný",
            "12 mesačný"});
            this.comboBoxTypeOfCard.Location = new System.Drawing.Point(229, 109);
            this.comboBoxTypeOfCard.Name = "comboBoxTypeOfCard";
            this.comboBoxTypeOfCard.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeOfCard.TabIndex = 8;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(422, 151);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(504, 151);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "späť";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NewCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(615, 215);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxTypeOfCard);
            this.Controls.Add(this.labelTypeOfCard);
            this.Controls.Add(this.labelNameAndSurname);
            this.Controls.Add(this.textBoxNameAndSurname);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDateOfCreation);
            this.Controls.Add(this.labelScannedCode);
            this.Controls.Add(this.textBoxScannedCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewCardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCardForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScannedCode;
        private System.Windows.Forms.Label labelScannedCode;
        private System.Windows.Forms.Label labelDateOfCreation;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelNameAndSurname;
        private System.Windows.Forms.TextBox textBoxNameAndSurname;
        private System.Windows.Forms.Label labelTypeOfCard;
        private System.Windows.Forms.ComboBox comboBoxTypeOfCard;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}