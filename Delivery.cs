using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Outback_Orders
{
    public partial class FormDelivery : Form
    {
       

        public FormDelivery()
        {
            InitializeComponent();
            
        }
        
        
        private void buttonDelivery_Click(object sender, EventArgs e)
        {

            string check;
            string check2;
            int count = 0;
            int num;
            int num2;
            check = textBoxZip.Text;
            check2 = textBoxPhone.Text;


            StreamWriter outputfile;
            outputfile = File.CreateText("Delivery.txt");
            outputfile.Close();

            //name storage
            outputfile = File.AppendText("Delivery.txt");
            outputfile.WriteLine(textBoxName.Text);
            outputfile.Close();

            //address storage
            outputfile = File.AppendText("Delivery.txt");
            outputfile.WriteLine(textBoxAddress.Text);
            outputfile.Close();

            //City storage
            outputfile = File.AppendText("Delivery.txt");
            outputfile.WriteLine(textBoxCity.Text);
            outputfile.Close();

            if (int.TryParse(check2, out num2)) // logic again doesnt work for the second one I do not know why.
            {
                //phone storage
                outputfile = File.AppendText("Delivery.txt");
                outputfile.WriteLine(textBoxPhone.Text);
                outputfile.Close();
                count++;
            }
            else
            {
                MessageBox.Show("enter a valid phone number");
            }

            if (int.TryParse(check, out num) && (textBoxZip.Text.Length == 5)) 
            {
                //ZipCode storage
                outputfile = File.AppendText("Delivery.txt");
                outputfile.WriteLine(textBoxZip.Text);
                outputfile.Close();
                count++;
            }
            else
            {
                MessageBox.Show("enter valid Zip");
            }
   
            //email storage
            outputfile = File.AppendText("Delivery.txt");
            outputfile.WriteLine(textBoxEmail.Text);
            outputfile.Close();

            //email storage
            outputfile = File.AppendText("Delivery.txt");
            outputfile.WriteLine(richTextBoxInstructions.Text);
            outputfile.Close();

            if (count == 2)
            {
                this.Hide();
                this.Close();
                Formpayment formpayment = new Formpayment();
                formpayment.ShowDialog();
            }
            
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {

        }
    }
}
