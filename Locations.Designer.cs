namespace Outback_Orders
{
    partial class FormLocations
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChooseL = new System.Windows.Forms.Button();
            this.radioButtonWT = new System.Windows.Forms.RadioButton();
            this.radioButtonWen = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.labelLocations = new System.Windows.Forms.Label();
            this.labelPickUp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxInStore = new System.Windows.Forms.CheckBox();
            this.checkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(190, 188);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonChooseL
            // 
            this.buttonChooseL.Location = new System.Drawing.Point(30, 188);
            this.buttonChooseL.Name = "buttonChooseL";
            this.buttonChooseL.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseL.TabIndex = 2;
            this.buttonChooseL.Text = "Select";
            this.buttonChooseL.UseVisualStyleBackColor = true;
            this.buttonChooseL.Click += new System.EventHandler(this.buttonChooseL_Click);
            // 
            // radioButtonWT
            // 
            this.radioButtonWT.AutoSize = true;
            this.radioButtonWT.Location = new System.Drawing.Point(12, 79);
            this.radioButtonWT.Name = "radioButtonWT";
            this.radioButtonWT.Size = new System.Drawing.Size(111, 17);
            this.radioButtonWT.TabIndex = 3;
            this.radioButtonWT.TabStop = true;
            this.radioButtonWT.Text = "Westover Terrace";
            this.radioButtonWT.UseVisualStyleBackColor = true;
            this.radioButtonWT.CheckedChanged += new System.EventHandler(this.radioButtonWT_CheckedChanged);
            // 
            // radioButtonWen
            // 
            this.radioButtonWen.AutoSize = true;
            this.radioButtonWen.Location = new System.Drawing.Point(129, 79);
            this.radioButtonWen.Name = "radioButtonWen";
            this.radioButtonWen.Size = new System.Drawing.Size(75, 17);
            this.radioButtonWen.TabIndex = 4;
            this.radioButtonWen.TabStop = true;
            this.radioButtonWen.Text = "Wendover";
            this.radioButtonWen.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(210, 79);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(71, 17);
            this.radioButtonHigh.TabIndex = 5;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "HighPoint";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // labelLocations
            // 
            this.labelLocations.AutoSize = true;
            this.labelLocations.Location = new System.Drawing.Point(85, 43);
            this.labelLocations.Name = "labelLocations";
            this.labelLocations.Size = new System.Drawing.Size(129, 13);
            this.labelLocations.TabIndex = 6;
            this.labelLocations.Text = "Choose Desired Location:";
            // 
            // labelPickUp
            // 
            this.labelPickUp.AutoSize = true;
            this.labelPickUp.Location = new System.Drawing.Point(85, 112);
            this.labelPickUp.Name = "labelPickUp";
            this.labelPickUp.Size = new System.Drawing.Size(126, 13);
            this.labelPickUp.TabIndex = 8;
            this.labelPickUp.Text = "Choose Pick Up Method:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxInStore);
            this.groupBox1.Controls.Add(this.checkBoxDelivery);
            this.groupBox1.Controls.Add(this.labelLocations);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.labelPickUp);
            this.groupBox1.Controls.Add(this.buttonChooseL);
            this.groupBox1.Controls.Add(this.radioButtonWT);
            this.groupBox1.Controls.Add(this.radioButtonWen);
            this.groupBox1.Controls.Add(this.radioButtonHigh);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 258);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxInStore
            // 
            this.checkBoxInStore.AutoSize = true;
            this.checkBoxInStore.Location = new System.Drawing.Point(148, 144);
            this.checkBoxInStore.Name = "checkBoxInStore";
            this.checkBoxInStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxInStore.Size = new System.Drawing.Size(63, 17);
            this.checkBoxInStore.TabIndex = 10;
            this.checkBoxInStore.Text = "In Store";
            this.checkBoxInStore.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelivery
            // 
            this.checkBoxDelivery.AutoSize = true;
            this.checkBoxDelivery.Location = new System.Drawing.Point(81, 144);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(64, 17);
            this.checkBoxDelivery.TabIndex = 9;
            this.checkBoxDelivery.Text = "Delivery";
            this.checkBoxDelivery.UseVisualStyleBackColor = true;
            // 
            // FormLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 310);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLocations";
            this.Text = "Locations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChooseL;
        private System.Windows.Forms.RadioButton radioButtonWT;
        private System.Windows.Forms.RadioButton radioButtonWen;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.Label labelLocations;
        private System.Windows.Forms.Label labelPickUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxInStore;
        public System.Windows.Forms.CheckBox checkBoxDelivery;
    }
}

