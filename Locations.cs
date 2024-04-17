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
using System.Net.NetworkInformation;

namespace Outback_Orders
{
    public partial class FormLocations : Form
    {
        
        public FormLocations()
        {
            InitializeComponent();
            
        }

        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonChooseL_Click(object sender, EventArgs e)
        {
            //this is just for receipt logic
            StreamWriter outputfile;
            outputfile = File.CreateText("Receipt.txt");
            outputfile.Close();

            //delivery logic

            if (radioButtonWT.Checked && checkBoxDelivery.Checked)
            {
                
                outputfile = File.CreateText("Receipt.txt");
                outputfile.WriteLine("1611 Westover Terrace\r\nGreensboro, NC 27408"); // takes two lines so target two index's in the future array.
                outputfile.Close();

                outputfile = File.AppendText("Receipt.txt");
                outputfile.WriteLine("Delivery");
                outputfile.Close();

                StreamWriter logic;
                logic = File.CreateText("Bool.txt");
                logic.WriteLine("true");
                logic.Close();

                FormMenu formMenu = new FormMenu();
                formMenu.labelbool.Text = "true";
                formMenu.ShowDialog();
            }
            else if (radioButtonWen.Checked && checkBoxDelivery.Checked)
            {
                
                outputfile = File.CreateText("Receipt.txt");
                outputfile.WriteLine("4518 W. Wendover Ave\r\nGreensboro, NC 27409"); // takes two lines so target two index's in the future array.
                outputfile.Close();

                outputfile = File.AppendText("Receipt.txt");
                outputfile.WriteLine("Delivery");
                outputfile.Close();

                StreamWriter logic;
                logic = File.CreateText("Bool.txt");
                logic.WriteLine("true");
                logic.Close();

                FormMenu formMenu = new FormMenu();
                formMenu.labelbool.Text = "true";
                formMenu.ShowDialog();
            }
            else if (radioButtonHigh.Checked && checkBoxDelivery.Checked)
            {
                
                outputfile = File.CreateText("Receipt.txt");
                outputfile.WriteLine("260 East Parris Avenue\r\nHigh Point, NC 27262"); // takes two lines so target two index's in the future array.
                outputfile.Close();

                outputfile = File.AppendText("Receipt.txt");
                outputfile.WriteLine("Delivery");
                outputfile.Close();

                StreamWriter logic;
                logic = File.CreateText("Bool.txt");
                logic.WriteLine("true");
                logic.Close();

                FormMenu formMenu = new FormMenu();
                formMenu.labelbool.Text = "true";
                formMenu.ShowDialog();
            }

            else if (radioButtonWT.Checked && checkBoxInStore.Checked)
            {
                
                outputfile = File.CreateText("Receipt.txt");
                outputfile.WriteLine("1611 Westover Terrace\r\nGreensboro, NC 27408"); // takes two lines so target two index's in the future array.
                outputfile.Close();

                outputfile = File.AppendText("Receipt.txt");
                outputfile.WriteLine("In Store");
                outputfile.Close();

                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }
            else if
            (radioButtonWen.Checked && checkBoxInStore.Checked)
            {
                
                outputfile = File.CreateText("Receipt.txt");
                outputfile.WriteLine("4518 W. Wendover Ave\r\nGreensboro, NC 27409"); // takes two lines so target two index's in the future array.
                outputfile.Close();

                outputfile = File.AppendText("Receipt.txt");
                outputfile.WriteLine("In Store");
                outputfile.Close();

                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }
            else if
            (radioButtonHigh.Checked && checkBoxInStore.Checked)
            {
               
                outputfile = File.CreateText("Receipt.txt");
                outputfile.WriteLine("260 East Parris Avenue\r\nHigh Point, NC 27262"); // takes two lines so target two index's in the future array.
                outputfile.Close();

                outputfile = File.AppendText("Receipt.txt");
                outputfile.WriteLine("In Store");
                outputfile.Close();

                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();

                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("please choose a pick up method");
            }
           
            
           


        }

        private void radioButtonDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
