namespace CardScanProgram
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
            this.btnCardsManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateCard
            // 
            this.buttonCreateCard.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCreateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateCard.Location = new System.Drawing.Point(55, 50);
            this.buttonCreateCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateCard.Name = "buttonCreateCard";
            this.buttonCreateCard.Size = new System.Drawing.Size(360, 196);
            this.buttonCreateCard.TabIndex = 0;
            this.buttonCreateCard.Text = "Predaj novej karty";
            this.buttonCreateCard.UseVisualStyleBackColor = false;
            this.buttonCreateCard.Click += new System.EventHandler(this.buttonCreateCard_Click);
            // 
            // buttonScanCard
            // 
            this.buttonScanCard.BackColor = System.Drawing.Color.LightGreen;
            this.buttonScanCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScanCard.Location = new System.Drawing.Point(55, 279);
            this.buttonScanCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonScanCard.Name = "buttonScanCard";
            this.buttonScanCard.Size = new System.Drawing.Size(363, 196);
            this.buttonScanCard.TabIndex = 1;
            this.buttonScanCard.Text = "Kontrola časovej permanentky";
            this.buttonScanCard.UseVisualStyleBackColor = false;
            this.buttonScanCard.Click += new System.EventHandler(this.buttonScanCard_Click);
            // 
            // btnCardsManagement
            // 
            this.btnCardsManagement.BackColor = System.Drawing.Color.LightBlue;
            this.btnCardsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCardsManagement.Location = new System.Drawing.Point(460, 50);
            this.btnCardsManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCardsManagement.Name = "btnCardsManagement";
            this.btnCardsManagement.Size = new System.Drawing.Size(363, 196);
            this.btnCardsManagement.TabIndex = 2;
            this.btnCardsManagement.Text = "Manazment vstupnej permanentky";
            this.btnCardsManagement.UseVisualStyleBackColor = false;
            this.btnCardsManagement.Click += new System.EventHandler(this.btnCardsManagement_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(460, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 196);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kontrola vstupnej permanentky";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCardsManagement);
            this.Controls.Add(this.buttonScanCard);
            this.Controls.Add(this.buttonCreateCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCard;
        private System.Windows.Forms.Button buttonScanCard;
        private System.Windows.Forms.Button btnCardsManagement;
        private System.Windows.Forms.Button button1;
    }
}

