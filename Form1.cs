/*
 * Menu
 * 10/9/23
 * Hawley
 * DDA
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Hawley
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void burgersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (burgersCheckBox.Checked == true)
            {
                burgersGroupBox.Visible = true;
            }
            else
            {
                burgersGroupBox.Visible = false;
            }
        }

        private void friesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCheckBox.Checked == true)
            {
                friesGroupBox.Visible = true;
            }
            else
            {
                friesGroupBox.Visible = false;
            }
        }

        private void DrinksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksCheckBox.Checked == true)
            {
                drinksGroupBox.Visible = true;
            }
            else
            {
                drinksGroupBox.Visible = false;
            }
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            const double REGULAR_BURGER = 4.19, ONE_TOPPING = 4.79, 
                BOTH = 5.39, SMALL = 2.39, MEDIUM = 3.09, LARGE = 4.99,
                SODA =1.69, WATER = 1.49;
            double total = 0;

            /*Dictates burger toppings*/

            if (burgersCheckBox.Checked == true)
            {
                if (regularRadioButton.Checked == true)
                {
                    total = REGULAR_BURGER;
                }
                else if (cheeseRadioButton.Checked == true || baconRadioButton.Checked == true)
                {
                    total = ONE_TOPPING;
                }
                else if (bothRadioButton.Checked == true)
                {
                    total = BOTH;
                }
            }


            /*Dictates fry size*/

            if (friesCheckBox.Checked == true)
            {
                if (smallRadioButton.Checked == true)
                {
                    total += SMALL;
                }
                else if (mediumRadioButton.Checked == true)
                {
                    total += MEDIUM;
                }
                else if (largeRadioButton.Checked == true)
                {
                    total += LARGE;
                }
            }

            /*Dictates Drink*/
            if (drinksCheckBox.Checked == true)
            {
                if (sodaRadioButton.Checked == true)
                {
                    total += SODA;
                }
                else if (waterRadioButton.Checked == true)
                {
                    total += WATER;
                }
            }

            ResultsLabel.Text = "$" + total;
        }
    }
}
