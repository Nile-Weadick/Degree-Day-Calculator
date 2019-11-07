using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degree_Day_Calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaring Variables

        int degreeDay, baseTemp, high, low, tempMean;

        //Initialize Variables
        private void Form1_Load(object sender, EventArgs e)
        {
            tempMean = 0;
            high = 0;
            low = 0;
            txtBxBT.Text = "65";
        }

        // Exiting application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //resetting labels and text boxes
            txtBxHigh.Text = string.Empty;
            txtBxLow.Text = string.Empty;
            txtBxBT.Text = "65";
            lblDD.Text = string.Empty;
            lblError.Text = string.Empty;

            //resetting variables

            high = 0;
            low = 0;

        }
 
        private void btnCalc_Click(object sender, EventArgs e)
        {
           bool goodConvert = true;

            //Convert textbox data into numbers                                                    
            try
            {
                low = int.Parse(txtBxLow.Text);
                high = int.Parse(txtBxHigh.Text);
                baseTemp = int.Parse(txtBxBT.Text);
                
            }
            catch
            {
                lblDD.Text = string.Empty;
                lblError.Text = "Missing Required Values";
             
                goodConvert = false;

            }
          
            //Calculating Temp Mean
            tempMean = (high + low) / 2;

            //Calculating the degree days
            degreeDay = baseTemp - tempMean;

            if (goodConvert)
            {

            // Display Results on screen 
            lblDD.Text = degreeDay + " Electrical Degree Days";
            lblError.Text = string.Empty;

            }

        }
    }
}
