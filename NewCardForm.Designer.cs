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
            this.textBoxScannedCode.Location = new System.Drawing.Point(305, 38);
            this.textBoxScannedCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxScannedCode.Name = "textBoxScannedCode";
            this.textBoxScannedCode.Size = new System.Drawing.Size(465, 22);
            this.textBoxScannedCode.TabIndex = 0;
            // 
            // labelScannedCode
            // 
            this.labelScannedCode.AutoSize = true;
            this.labelScannedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScannedCode.Location = new System.Drawing.Point(23, 32);
            this.labelScannedCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScannedCode.Name = "labelScannedCode";
            this.labelScannedCode.Size = new System.Drawing.Size(246, 31);
            this.labelScannedCode.TabIndex = 1;
            this.labelScannedCode.Text = "Naskenovany kód: ";
            // 
            // labelDateOfCreation
            // 
            this.labelDateOfCreation.AutoSize = true;
            this.labelDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfCreation.Location = new System.Drawing.Point(23, 64);
            this.labelDateOfCreation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfCreation.Name = "labelDateOfCreation";
            this.labelDateOfCreation.Size = new System.Drawing.Size(241, 31);
            this.labelDateOfCreation.TabIndex = 3;
            this.labelDateOfCreation.Text = "Datum vytvorenia: ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(305, 71);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // labelNameAndSurname
            // 
            this.labelNameAndSurname.AutoSize = true;
            this.labelNameAndSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameAndSurname.Location = new System.Drawing.Point(23, 96);
            this.labelNameAndSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameAndSurname.Name = "labelNameAndSurname";
            this.labelNameAndSurname.Size = new System.Drawing.Size(240, 31);
            this.labelNameAndSurname.TabIndex = 6;
            this.labelNameAndSurname.Text = "Meno a priezvisko:";
            // 
            // textBoxNameAndSurname
            // 
            this.textBoxNameAndSurname.Location = new System.Drawing.Point(305, 103);
            this.textBoxNameAndSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameAndSurname.Name = "textBoxNameAndSurname";
            this.textBoxNameAndSurname.Size = new System.Drawing.Size(465, 22);
            this.textBoxNameAndSurname.TabIndex = 5;
            // 
            // labelTypeOfCard
            // 
            this.labelTypeOfCard.AutoSize = true;
            this.labelTypeOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeOfCard.Location = new System.Drawing.Point(23, 127);
            this.labelTypeOfCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeOfCard.Name = "labelTypeOfCard";
            this.labelTypeOfCard.Size = new System.Drawing.Size(142, 31);
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
            "12 mesačný",
            "15 vstupov"});
            this.comboBoxTypeOfCard.Location = new System.Drawing.Point(305, 134);
            this.comboBoxTypeOfCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTypeOfCard.Name = "comboBoxTypeOfCard";
            this.comboBoxTypeOfCard.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTypeOfCard.TabIndex = 8;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(563, 186);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(672, 186);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "späť";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NewCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(820, 265);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewCardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCardForm_FormClosing);
            this.Load += new System.EventHandler(this.NewCardForm_Load);
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