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
using System.Diagnostics;

namespace Outback_Orders
{
    public partial class FormReceipt : Form
    {
        string[] logic = File.ReadAllLines("C:\\Users\\Holden\\source\\repos\\Outback Orders\\bin\\Debug\\Bool.txt");
        string[] delivery = File.ReadAllLines("C:\\Users\\Holden\\source\\repos\\Outback Orders\\bin\\Debug\\Delivery.txt");
        string[] receipt = File.ReadAllLines("C:\\Users\\Holden\\source\\repos\\Outback Orders\\bin\\Debug\\Receipt.txt");
        string[] receipt2 = File.ReadAllLines("C:\\Users\\Holden\\source\\repos\\Outback Orders\\bin\\Debug\\Receipt2.txt");
        string[] total = File.ReadAllLines("C:\\Users\\Holden\\source\\repos\\Outback Orders\\bin\\Debug\\Total.txt");
        public FormReceipt()
        {
            InitializeComponent();

            labelLocationIn.Text = receipt[0] + " " + receipt[1];
            
            labelPickMethod.Text = receipt[2];

            labelTotal.Text = ("$" + total[0]);



            
            if (logic.Length > 0)
            {
                labelDelivery.Visible = true;
                labelName.Visible = true;
                labelAddress.Visible = true;
                labelName.Text = (delivery[0]);
                labelAddress.Text = delivery[1] + " " + delivery[2] + " " + delivery[3];
            }
            else
            {
                labelDelivery.Text = "";
                labelName.Text = "";
                labelAddress.Text = "";
              
            }
               

            

            for (int i = 0; i < receipt2.Length; i++)
            {
                if (receipt2.Length == 1)
                {
                    labelO1.Text = receipt2[0];
                }
                else if (receipt2.Length == 2)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                }
                else if (receipt2.Length == 3)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                }
                else if (receipt2.Length == 4)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                }
                else if (receipt2.Length == 4)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                }
                else if (receipt2.Length == 5)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                }
                else if (receipt2.Length == 6)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                }
                else if (receipt2.Length == 7)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                }
                else if (receipt2.Length == 8)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                }
                else if (receipt2.Length == 8)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                }
                else if (receipt2.Length == 9)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                }
                else if (receipt2.Length == 10)
                {
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                }
                else if (receipt2.Length == 11)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];

                }
                else if (receipt2.Length == 12)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];

                }
                else if (receipt2.Length == 13)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];

                }
                else if (receipt2.Length == 14)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];
                    labelO14.Text = receipt2[13];

                }
                else if (receipt2.Length == 15)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];
                    labelO14.Text = receipt2[13];
                    labelO15.Text = receipt2[14];

                }
                else if (receipt2.Length == 16)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];
                    labelO14.Text = receipt2[13];
                    labelO15.Text = receipt2[14];
                    labelO16.Text = receipt2[15];

                }
                else if (receipt2.Length == 17)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];
                    labelO14.Text = receipt2[13];
                    labelO15.Text = receipt2[14];
                    labelO16.Text = receipt2[15];
                    labelO17.Text = receipt2[16];

                }
                else if (receipt2.Length == 18)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];
                    labelO14.Text = receipt2[13];
                    labelO15.Text = receipt2[14];
                    labelO16.Text = receipt2[15];
                    labelO17.Text = receipt2[16];
                    labelO18.Text = receipt2[17];

                }
                else if (receipt2.Length == 19)
                {
                    groupBoxOrder2.Visible = true;
                    labelO1.Text = receipt2[0];
                    labelO2.Text = receipt2[1];
                    labelO3.Text = receipt2[2];
                    labelO4.Text = receipt2[3];
                    labelO5.Text = receipt2[4];
                    labelO6.Text = receipt2[5];
                    labelO7.Text = receipt2[6];
                    labelO8.Text = receipt2[7];
                    labelO9.Text = receipt2[8];
                    labelO10.Text = receipt2[9];
                    labelO11.Text = receipt2[10];
                    labelO12.Text = receipt2[11];
                    labelO13.Text = receipt2[12];
                    labelO14.Text = receipt2[13];
                    labelO15.Text = receipt2[14];
                    labelO16.Text = receipt2[15];
                    labelO17.Text = receipt2[16];
                    labelO18.Text = receipt2[17];
                    labelO19.Text = receipt2[18];

                }
            }

            
            
        }

        private void buttonExit3_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            outputfile = File.CreateText("Bool.txt");
            outputfile.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelO3_Click(object sender, EventArgs e)
        {

        }
    }
}
