using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outback_Orders
{
    public partial class Formpayment : Form
    {
        public Formpayment()
        {
            InitializeComponent();
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            outputfile = File.CreateText("Payment.txt");
            outputfile.Close();

            //name on card storage
            outputfile = File.AppendText("Payment.txt");
            outputfile.WriteLine(textBoxNCard.Text);
            outputfile.Close();


            // restriction logic 
            string check;
            string check2;
            int count = 0;
            int num;
            check = textBoxCardNum.Text;
            check2 = textBoxCVC.Text;
          
            
            if ((int.TryParse(check, out num))) // the length logic didnt work here? I dont know how to limit 
            {
                //card number storage
                outputfile = File.AppendText("Payment.txt");
                outputfile.WriteLine(textBoxCardNum.Text);
                outputfile.Close();
                count++;
            }else
            {
                MessageBox.Show("input a valid number");
            }
           
 
            //EXP Date storage
            outputfile = File.AppendText("Payment.txt");
            outputfile.WriteLine(textBoxExpDate.Text);
            outputfile.Close();

            if (int.TryParse(check2, out  num) && (textBoxCVC.Text.Length == 3))
            {
                //CVC storage
                outputfile = File.AppendText("Payment.txt");
                outputfile.WriteLine(textBoxCVC.Text);
                outputfile.Close();

                count++;
            }
            else
            {
                MessageBox.Show("input correct CVC number.");
            }

            if (count == 2)
            {
                FormReceipt formReceipt = new FormReceipt();
                formReceipt.ShowDialog();
                this.Hide();
                this.Close();
            }
        }
    }
}
