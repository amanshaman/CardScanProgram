﻿namespace CardScanProgram
{
    partial class Form1
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
            this.buttonCreateCard = new System.Windows.Forms.Button();
            this.buttonScanCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateCard
            // 
            this.buttonCreateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateCard.Location = new System.Drawing.Point(41, 41);
            this.buttonCreateCard.Name = "buttonCreateCard";
            this.buttonCreateCard.Size = new System.Drawing.Size(270, 159);
            this.buttonCreateCard.TabIndex = 0;
            this.buttonCreateCard.Text = "Vytvorenie novej karty";
            this.buttonCreateCard.UseVisualStyleBackColor = true;
            this.buttonCreateCard.Click += new System.EventHandler(this.buttonCreateCard_Click);
            // 
            // buttonScanCard
            // 
            this.buttonScanCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScanCard.Location = new System.Drawing.Point(345, 41);
            this.buttonScanCard.Name = "buttonScanCard";
            this.buttonScanCard.Size = new System.Drawing.Size(272, 159);
            this.buttonScanCard.TabIndex = 1;
            this.buttonScanCard.Text = "kontrola existujucej karty";
            this.buttonScanCard.UseVisualStyleBackColor = true;
            this.buttonScanCard.Click += new System.EventHandler(this.buttonScanCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 237);
            this.Controls.Add(this.buttonScanCard);
            this.Controls.Add(this.buttonCreateCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCard;
        private System.Windows.Forms.Button buttonScanCard;
    }
}

