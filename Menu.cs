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
    public partial class FormMenu : Form
    {
        double total = 0;
        double total2 = 0;
        int count = 1;
        double[] totalArray = new double[19];
        public FormMenu()
        {
            InitializeComponent();
           
        }
        
        public void TotalCalc()
        {
          

            if (count <= 1)
            {

                StreamWriter outputfile;
                outputfile = File.CreateText("Receipt2.txt");
                outputfile.Close();

                //an array of length 18 as there are 19 options on the menu. used for summing.
                double[] totalArray = new double[19];
                //this is going to be the code for the calculation to be turned into if else for project requirements.

                //appetizers 
                if (checkBoxBloomShrimp.Checked)
                {
                    totalArray[0] = 13.99; //position of array manually corresponding to placement on menu.
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Bloomin' Fried Shrimp $13.99");
                    outputfile.Close();
                }
                if (checkBoxShrooms.Checked)
                {
                    totalArray[1] = 8.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Sydney 'Shrooms $8.99");
                    outputfile.Close();
                }
                if (checkBoxWings.Checked)
                {
                    totalArray[2] = 14.99;
                   
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Kookaburra Wings $14.99");
                    outputfile.Close();
                }
                if (checkBoxMacBites.Checked)
                {
                    totalArray[3] = 7.99;
                   
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("SteakHouse Mac&Cheese Bites $7.99");
                    outputfile.Close();
                }
                if (checkBoxCShrimp.Checked)
                {
                    totalArray[4] = 13.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Gold Coast Coconut Shrimp $13.99");
                    outputfile.Close();
                }

                //Entrees
                if (checkBoxRibeye.Checked)
                {
                    totalArray[5] = 27.99;
                   
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Ribeye 13 oz. $27.99");
                    outputfile.Close();
                }
                if (checkBoxClassicPR.Checked)
                {
                    totalArray[6] = 26.99;
                   
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Classic Prime Rib 12 oz. $26.99");
                    outputfile.Close();
                }
                if (checkBoxBIStrip.Checked)
                {
                    totalArray[7] = 30.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Bone-In New York Strip 16 oz. $30.99");
                    outputfile.Close();
                }
                if (checkBoxSGS.Checked)
                {
                    totalArray[8] = 27.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Sirloin and Grilled Shrimp 6 oz. $27.99");
                    outputfile.Close();
                }
                if (checkBoxFMLobster.Checked)
                {
                    totalArray[9] = 34.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Filet MIgnon and Lobster 6 oz. $34.99");
                    outputfile.Close();
                }

                //Drinks
                if (checkBoxKPunch.Checked)
                {
                    totalArray[10] = 8.49;
                 
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Koala Punch $8.49");
                    outputfile.Close();
                }
                if (checkBoxFountain.Checked)
                {
                    totalArray[11] = 3.99;
                   
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Fountain Drink $3.99");
                    outputfile.Close();
                }
                if (checkBoxSLemonade.Checked)
                {
                    totalArray[12] = 3.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Strawberry Lemonade $3.99");
                    outputfile.Close();
                }
                if (checkBoxSTea.Checked)
                {
                    totalArray[13] = 3.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Sweet Tea $3.99");
                    outputfile.Close();
                }
                if (checkBoxWater.Checked)
                {
                    totalArray[14] = 0;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Water");
                    outputfile.Close();
                }

                //Sides
                if (checkBoxFries.Checked)
                {
                    totalArray[15] = 3.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Aussie Fries $3.99");
                    outputfile.Close();
                }
                if (checkBoxLMPotatoes.Checked)
                {
                    totalArray[16] = 5.99;
                   
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Loaded Mashed Potatoes $5.99");
                    outputfile.Close();
                }
                if (checkBoxMac.Checked)
                {
                    totalArray[17] = 5.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("SteakHouse Mac and Cheese $5.99");
                    outputfile.Close();
                }
                if (checkBoxAsparagus.Checked)
                {
                    totalArray[18] = 5.99;
                    
                    outputfile = File.AppendText("Receipt2.txt");
                    outputfile.WriteLine("Asparagus $5.99");
                    outputfile.Close();
                }

                // this is the equation to add everything into total 

                for (int i = 0; i < totalArray.Length; i++)
                {
                    total += totalArray[i];
                
                }
                Array.Clear(totalArray, 0, totalArray.Length);
                total2 = total;
                count++;
                
            }
            else if (count > 1)
            {
                MessageBox.Show("you have ordered twice the old total will be displayed thank you for ordering with outback orders!");
            }
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        private void buttonExit2_Click(object sender, EventArgs e) //this is now the back button
        {
            this.Close();
        }

        private void labelApps_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e) //this is now the clear button 
        {
            
            
        }

        public void buttonOrder_Click(object sender, EventArgs e)
        {
            
            TotalCalc();

            StreamWriter outputfile;
            outputfile = File.CreateText("Total.txt");
            outputfile.WriteLine(total2);
            outputfile.Close();

          if(labelbool.Text == "true")
            {
                FormDelivery formDelivery = new FormDelivery();
                formDelivery.ShowDialog();
            }else
            {

                Formpayment formpayment = new Formpayment();
                formpayment.ShowDialog();
            }

            this.Hide();
            this.Close();
        }

        private void checkBoxKPunch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
