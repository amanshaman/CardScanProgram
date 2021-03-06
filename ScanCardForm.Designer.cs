﻿namespace CardScanProgram
{
    partial class ScanCardForm
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
            this.labelScannedCode = new System.Windows.Forms.Label();
            this.textBoxScannedCode = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamAndSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelIsValid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScannedCode
            // 
            this.labelScannedCode.AutoSize = true;
            this.labelScannedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScannedCode.Location = new System.Drawing.Point(12, 40);
            this.labelScannedCode.Name = "labelScannedCode";
            this.labelScannedCode.Size = new System.Drawing.Size(196, 25);
            this.labelScannedCode.TabIndex = 3;
            this.labelScannedCode.Text = "Naskenovany kód: ";
            // 
            // textBoxScannedCode
            // 
            this.textBoxScannedCode.Location = new System.Drawing.Point(214, 45);
            this.textBoxScannedCode.Name = "textBoxScannedCode";
            this.textBoxScannedCode.Size = new System.Drawing.Size(350, 20);
            this.textBoxScannedCode.TabIndex = 2;
            this.textBoxScannedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxScannedCode_KeyDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(489, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "späť";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(399, 204);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Meno a priezvisko:";
            // 
            // textBoxNamAndSurname
            // 
            this.textBoxNamAndSurname.Enabled = false;
            this.textBoxNamAndSurname.Location = new System.Drawing.Point(214, 80);
            this.textBoxNamAndSurname.Name = "textBoxNamAndSurname";
            this.textBoxNamAndSurname.Size = new System.Drawing.Size(350, 20);
            this.textBoxNamAndSurname.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dátum vydania: ";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(214, 117);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(350, 20);
            this.textBoxDate.TabIndex = 15;
            // 
            // labelIsValid
            // 
            this.labelIsValid.AutoSize = true;
            this.labelIsValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIsValid.Location = new System.Drawing.Point(115, 153);
            this.labelIsValid.Name = "labelIsValid";
            this.labelIsValid.Size = new System.Drawing.Size(88, 25);
            this.labelIsValid.TabIndex = 30;
            this.labelIsValid.Text = "isValid?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Validny: ";
            // 
            // ScanCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 279);
            this.Controls.Add(this.labelIsValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNamAndSurname);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelScannedCode);
            this.Controls.Add(this.textBoxScannedCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ScanCardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanCardForm_FormClosing);
            this.Load += new System.EventHandler(this.ScanCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScannedCode;
        private System.Windows.Forms.TextBox textBoxScannedCode;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamAndSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelIsValid;
        private System.Windows.Forms.Label label3;
    }
}