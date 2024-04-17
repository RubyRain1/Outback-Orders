namespace Outback_Orders
{
    partial class FormReceipt
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
            this.buttonExit3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLocationIn = new System.Windows.Forms.Label();
            this.labelPickUp = new System.Windows.Forms.Label();
            this.labelPickMethod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.labelO1 = new System.Windows.Forms.Label();
            this.labelO2 = new System.Windows.Forms.Label();
            this.labelO3 = new System.Windows.Forms.Label();
            this.labelO4 = new System.Windows.Forms.Label();
            this.labelO5 = new System.Windows.Forms.Label();
            this.labelO6 = new System.Windows.Forms.Label();
            this.labelO7 = new System.Windows.Forms.Label();
            this.labelO8 = new System.Windows.Forms.Label();
            this.labelO9 = new System.Windows.Forms.Label();
            this.labelO10 = new System.Windows.Forms.Label();
            this.labelO11 = new System.Windows.Forms.Label();
            this.labelO12 = new System.Windows.Forms.Label();
            this.labelO13 = new System.Windows.Forms.Label();
            this.labelO14 = new System.Windows.Forms.Label();
            this.labelO17 = new System.Windows.Forms.Label();
            this.labelO16 = new System.Windows.Forms.Label();
            this.labelO15 = new System.Windows.Forms.Label();
            this.labelO18 = new System.Windows.Forms.Label();
            this.groupBoxOrder1 = new System.Windows.Forms.GroupBox();
            this.groupBoxOrder2 = new System.Windows.Forms.GroupBox();
            this.labelO19 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.groupBoxOrder1.SuspendLayout();
            this.groupBoxOrder2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit3
            // 
            this.buttonExit3.Location = new System.Drawing.Point(929, 592);
            this.buttonExit3.Name = "buttonExit3";
            this.buttonExit3.Size = new System.Drawing.Size(75, 23);
            this.buttonExit3.TabIndex = 0;
            this.buttonExit3.Text = "Exit";
            this.buttonExit3.UseVisualStyleBackColor = true;
            this.buttonExit3.Click += new System.EventHandler(this.buttonExit3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // labelLocationIn
            // 
            this.labelLocationIn.AutoSize = true;
            this.labelLocationIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationIn.Location = new System.Drawing.Point(12, 66);
            this.labelLocationIn.Name = "labelLocationIn";
            this.labelLocationIn.Size = new System.Drawing.Size(125, 24);
            this.labelLocationIn.TabIndex = 3;
            this.labelLocationIn.Text = "insert location";
            this.labelLocationIn.UseWaitCursor = true;
            // 
            // labelPickUp
            // 
            this.labelPickUp.AutoSize = true;
            this.labelPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickUp.Location = new System.Drawing.Point(12, 111);
            this.labelPickUp.Name = "labelPickUp";
            this.labelPickUp.Size = new System.Drawing.Size(67, 20);
            this.labelPickUp.TabIndex = 4;
            this.labelPickUp.Text = "Pick Up:";
            // 
            // labelPickMethod
            // 
            this.labelPickMethod.AutoSize = true;
            this.labelPickMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickMethod.Location = new System.Drawing.Point(11, 133);
            this.labelPickMethod.Name = "labelPickMethod";
            this.labelPickMethod.Size = new System.Drawing.Size(142, 25);
            this.labelPickMethod.TabIndex = 5;
            this.labelPickMethod.Text = "insert method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(925, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(924, 554);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(109, 25);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total here";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.Location = new System.Drawing.Point(384, 138);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(90, 33);
            this.labelOrders.TabIndex = 8;
            this.labelOrders.Text = "Order";
            // 
            // labelO1
            // 
            this.labelO1.AutoSize = true;
            this.labelO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO1.Location = new System.Drawing.Point(6, 19);
            this.labelO1.Name = "labelO1";
            this.labelO1.Size = new System.Drawing.Size(0, 24);
            this.labelO1.TabIndex = 9;
            this.labelO1.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelO2
            // 
            this.labelO2.AutoSize = true;
            this.labelO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO2.Location = new System.Drawing.Point(6, 56);
            this.labelO2.Name = "labelO2";
            this.labelO2.Size = new System.Drawing.Size(0, 24);
            this.labelO2.TabIndex = 10;
            // 
            // labelO3
            // 
            this.labelO3.AutoSize = true;
            this.labelO3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO3.Location = new System.Drawing.Point(6, 90);
            this.labelO3.Name = "labelO3";
            this.labelO3.Size = new System.Drawing.Size(0, 24);
            this.labelO3.TabIndex = 11;
            this.labelO3.Click += new System.EventHandler(this.labelO3_Click);
            // 
            // labelO4
            // 
            this.labelO4.AutoSize = true;
            this.labelO4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO4.Location = new System.Drawing.Point(6, 125);
            this.labelO4.Name = "labelO4";
            this.labelO4.Size = new System.Drawing.Size(0, 24);
            this.labelO4.TabIndex = 12;
            // 
            // labelO5
            // 
            this.labelO5.AutoSize = true;
            this.labelO5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO5.Location = new System.Drawing.Point(6, 161);
            this.labelO5.Name = "labelO5";
            this.labelO5.Size = new System.Drawing.Size(0, 24);
            this.labelO5.TabIndex = 13;
            // 
            // labelO6
            // 
            this.labelO6.AutoSize = true;
            this.labelO6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO6.Location = new System.Drawing.Point(6, 195);
            this.labelO6.Name = "labelO6";
            this.labelO6.Size = new System.Drawing.Size(0, 24);
            this.labelO6.TabIndex = 14;
            // 
            // labelO7
            // 
            this.labelO7.AutoSize = true;
            this.labelO7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO7.Location = new System.Drawing.Point(6, 228);
            this.labelO7.Name = "labelO7";
            this.labelO7.Size = new System.Drawing.Size(0, 24);
            this.labelO7.TabIndex = 15;
            // 
            // labelO8
            // 
            this.labelO8.AutoSize = true;
            this.labelO8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO8.Location = new System.Drawing.Point(6, 261);
            this.labelO8.Name = "labelO8";
            this.labelO8.Size = new System.Drawing.Size(0, 24);
            this.labelO8.TabIndex = 16;
            // 
            // labelO9
            // 
            this.labelO9.AutoSize = true;
            this.labelO9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO9.Location = new System.Drawing.Point(6, 290);
            this.labelO9.Name = "labelO9";
            this.labelO9.Size = new System.Drawing.Size(0, 24);
            this.labelO9.TabIndex = 17;
            // 
            // labelO10
            // 
            this.labelO10.AutoSize = true;
            this.labelO10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO10.Location = new System.Drawing.Point(6, 321);
            this.labelO10.Name = "labelO10";
            this.labelO10.Size = new System.Drawing.Size(0, 24);
            this.labelO10.TabIndex = 18;
            // 
            // labelO11
            // 
            this.labelO11.AutoSize = true;
            this.labelO11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO11.Location = new System.Drawing.Point(7, 16);
            this.labelO11.Name = "labelO11";
            this.labelO11.Size = new System.Drawing.Size(0, 24);
            this.labelO11.TabIndex = 19;
            // 
            // labelO12
            // 
            this.labelO12.AutoSize = true;
            this.labelO12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO12.Location = new System.Drawing.Point(7, 56);
            this.labelO12.Name = "labelO12";
            this.labelO12.Size = new System.Drawing.Size(0, 24);
            this.labelO12.TabIndex = 20;
            // 
            // labelO13
            // 
            this.labelO13.AutoSize = true;
            this.labelO13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO13.Location = new System.Drawing.Point(7, 90);
            this.labelO13.Name = "labelO13";
            this.labelO13.Size = new System.Drawing.Size(0, 24);
            this.labelO13.TabIndex = 21;
            // 
            // labelO14
            // 
            this.labelO14.AutoSize = true;
            this.labelO14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO14.Location = new System.Drawing.Point(7, 125);
            this.labelO14.Name = "labelO14";
            this.labelO14.Size = new System.Drawing.Size(0, 24);
            this.labelO14.TabIndex = 22;
            // 
            // labelO17
            // 
            this.labelO17.AutoSize = true;
            this.labelO17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO17.Location = new System.Drawing.Point(7, 228);
            this.labelO17.Name = "labelO17";
            this.labelO17.Size = new System.Drawing.Size(0, 24);
            this.labelO17.TabIndex = 23;
            // 
            // labelO16
            // 
            this.labelO16.AutoSize = true;
            this.labelO16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO16.Location = new System.Drawing.Point(7, 195);
            this.labelO16.Name = "labelO16";
            this.labelO16.Size = new System.Drawing.Size(0, 24);
            this.labelO16.TabIndex = 24;
            // 
            // labelO15
            // 
            this.labelO15.AutoSize = true;
            this.labelO15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO15.Location = new System.Drawing.Point(7, 161);
            this.labelO15.Name = "labelO15";
            this.labelO15.Size = new System.Drawing.Size(0, 24);
            this.labelO15.TabIndex = 25;
            // 
            // labelO18
            // 
            this.labelO18.AutoSize = true;
            this.labelO18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO18.Location = new System.Drawing.Point(7, 261);
            this.labelO18.Name = "labelO18";
            this.labelO18.Size = new System.Drawing.Size(0, 24);
            this.labelO18.TabIndex = 26;
            // 
            // groupBoxOrder1
            // 
            this.groupBoxOrder1.Controls.Add(this.labelO1);
            this.groupBoxOrder1.Controls.Add(this.labelO4);
            this.groupBoxOrder1.Controls.Add(this.labelO2);
            this.groupBoxOrder1.Controls.Add(this.labelO3);
            this.groupBoxOrder1.Controls.Add(this.labelO5);
            this.groupBoxOrder1.Controls.Add(this.labelO6);
            this.groupBoxOrder1.Controls.Add(this.labelO7);
            this.groupBoxOrder1.Controls.Add(this.labelO8);
            this.groupBoxOrder1.Controls.Add(this.labelO9);
            this.groupBoxOrder1.Controls.Add(this.labelO10);
            this.groupBoxOrder1.Location = new System.Drawing.Point(16, 191);
            this.groupBoxOrder1.Name = "groupBoxOrder1";
            this.groupBoxOrder1.Size = new System.Drawing.Size(371, 374);
            this.groupBoxOrder1.TabIndex = 27;
            this.groupBoxOrder1.TabStop = false;
            // 
            // groupBoxOrder2
            // 
            this.groupBoxOrder2.Controls.Add(this.labelO19);
            this.groupBoxOrder2.Controls.Add(this.labelO12);
            this.groupBoxOrder2.Controls.Add(this.labelO11);
            this.groupBoxOrder2.Controls.Add(this.labelO18);
            this.groupBoxOrder2.Controls.Add(this.labelO13);
            this.groupBoxOrder2.Controls.Add(this.labelO15);
            this.groupBoxOrder2.Controls.Add(this.labelO14);
            this.groupBoxOrder2.Controls.Add(this.labelO16);
            this.groupBoxOrder2.Controls.Add(this.labelO17);
            this.groupBoxOrder2.Location = new System.Drawing.Point(458, 191);
            this.groupBoxOrder2.Name = "groupBoxOrder2";
            this.groupBoxOrder2.Size = new System.Drawing.Size(415, 374);
            this.groupBoxOrder2.TabIndex = 28;
            this.groupBoxOrder2.TabStop = false;
            this.groupBoxOrder2.Visible = false;
            // 
            // labelO19
            // 
            this.labelO19.AutoSize = true;
            this.labelO19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO19.Location = new System.Drawing.Point(7, 290);
            this.labelO19.Name = "labelO19";
            this.labelO19.Size = new System.Drawing.Size(0, 24);
            this.labelO19.TabIndex = 27;
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelivery.Location = new System.Drawing.Point(726, 43);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(68, 20);
            this.labelDelivery.TabIndex = 29;
            this.labelDelivery.Text = "Delivery:";
            this.labelDelivery.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(726, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 24);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "label4";
            this.labelName.Visible = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(726, 107);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 24);
            this.labelAddress.TabIndex = 31;
            this.labelAddress.Text = "label3";
            this.labelAddress.Visible = false;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 627);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDelivery);
            this.Controls.Add(this.groupBoxOrder2);
            this.Controls.Add(this.groupBoxOrder1);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPickMethod);
            this.Controls.Add(this.labelPickUp);
            this.Controls.Add(this.labelLocationIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit3);
            this.DoubleBuffered = true;
            this.Name = "FormReceipt";
            this.Text = "Receipt";
            this.groupBoxOrder1.ResumeLayout(false);
            this.groupBoxOrder1.PerformLayout();
            this.groupBoxOrder2.ResumeLayout(false);
            this.groupBoxOrder2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLocationIn;
        private System.Windows.Forms.Label labelPickUp;
        private System.Windows.Forms.Label labelPickMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelO1;
        private System.Windows.Forms.Label labelO2;
        private System.Windows.Forms.Label labelO3;
        private System.Windows.Forms.Label labelO4;
        private System.Windows.Forms.Label labelO5;
        private System.Windows.Forms.Label labelO6;
        private System.Windows.Forms.Label labelO7;
        private System.Windows.Forms.Label labelO8;
        private System.Windows.Forms.Label labelO9;
        private System.Windows.Forms.Label labelO10;
        private System.Windows.Forms.Label labelO11;
        private System.Windows.Forms.Label labelO12;
        private System.Windows.Forms.Label labelO13;
        private System.Windows.Forms.Label labelO14;
        private System.Windows.Forms.Label labelO17;
        private System.Windows.Forms.Label labelO16;
        private System.Windows.Forms.Label labelO15;
        private System.Windows.Forms.Label labelO18;
        private System.Windows.Forms.GroupBox groupBoxOrder1;
        private System.Windows.Forms.GroupBox groupBoxOrder2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelO19;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
    }
}