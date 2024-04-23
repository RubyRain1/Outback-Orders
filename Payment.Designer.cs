namespace Outback_Orders
{
    partial class Formpayment
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
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNCard = new System.Windows.Forms.TextBox();
            this.labelCardNum = new System.Windows.Forms.Label();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelCVC = new System.Windows.Forms.Label();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxCVC = new System.Windows.Forms.TextBox();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(35, 321);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(75, 23);
            this.buttonPay.TabIndex = 0;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.Location = new System.Drawing.Point(241, 321);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(75, 23);
            this.buttonBack2.TabIndex = 1;
            this.buttonBack2.Text = "Back";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name On Card:";
            // 
            // textBoxNCard
            // 
            this.textBoxNCard.Location = new System.Drawing.Point(35, 103);
            this.textBoxNCard.Name = "textBoxNCard";
            this.textBoxNCard.Size = new System.Drawing.Size(281, 20);
            this.textBoxNCard.TabIndex = 3;
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.Location = new System.Drawing.Point(45, 138);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Size = new System.Drawing.Size(72, 13);
            this.labelCardNum.TabIndex = 5;
            this.labelCardNum.Text = "Card Number:";
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Location = new System.Drawing.Point(45, 199);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(60, 13);
            this.labelExpDate.TabIndex = 6;
            this.labelExpDate.Text = "EXP. Date:";
            // 
            // labelCVC
            // 
            this.labelCVC.AutoSize = true;
            this.labelCVC.Location = new System.Drawing.Point(259, 199);
            this.labelCVC.Name = "labelCVC";
            this.labelCVC.Size = new System.Drawing.Size(31, 13);
            this.labelCVC.TabIndex = 7;
            this.labelCVC.Text = "CVC:";
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(35, 215);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.Size = new System.Drawing.Size(75, 20);
            this.textBoxExpDate.TabIndex = 8;
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Location = new System.Drawing.Point(251, 215);
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(65, 20);
            this.textBoxCVC.TabIndex = 9;
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(35, 154);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(281, 20);
            this.textBoxCardNum.TabIndex = 4;
            // 
            // Formpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 372);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.textBoxExpDate);
            this.Controls.Add(this.labelCVC);
            this.Controls.Add(this.labelExpDate);
            this.Controls.Add(this.labelCardNum);
            this.Controls.Add(this.textBoxCardNum);
            this.Controls.Add(this.textBoxNCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.buttonPay);
            this.Name = "Formpayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNCard;
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelCVC;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.TextBox textBoxCVC;
        private System.Windows.Forms.TextBox textBoxCardNum;
    }
}