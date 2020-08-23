using ISYS250HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTM250Project1
{
    public static class Validator
    {
        /// <summary>
        /// Declares method for if certain criteria is present
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "") //if textbox is blank
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Declares method for if certain combo boxes are selected
        /// </summary>
        /// <param name = "comboBox" ></ param >
        /// < param name="name"></param>
        /// <returns></returns>
        public static bool IsSelected(ComboBox comboBox, string name)
        {
            if (comboBox.SelectedIndex == -1) //if no combo box option is selected
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Declares method for if certain criteria is an integer
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsInteger(TextBox textBox, string name)
        {
            long longNumber = 0;
            if (Int64.TryParse(textBox.Text, out longNumber)) //if the textbox can output an integer based on what's inside the textbox
            {
                if (longNumber > 0)
                    return true;
                else
                {
                    MessageBox.Show("Quantity must be a whole numerical value only.", name);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Quantity must be a numerical value only.", name);
                return false;
            }
        }

        /// <summary>
        /// Declares method to test whether delivery city is within range
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsWithinCityRange(TextBox textBox)
        {

            //input
            string strDeliveryCity = Convert.ToString(textBox.Text);

            //procressing
            strDeliveryCity = strDeliveryCity.ToUpper();

            //if (rdoDelivery.Checked)
            //{
            if (strDeliveryCity == "COLLEGE STATION" || strDeliveryCity == "BRYAN")
            {
                return true;
            }

            else
            {
                MessageBox.Show("Your city must be either College Station or Bryan in order to qualify for delivery.", "Delivery Address Error");
                return false;
            }
        }
        //else
        //{
        //    return true;
        //}


        /// <summary>
        /// Validates Texas is the state that is chosen for delivery
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsWithinStateRange(TextBox textBox)
        {
            //input
            string strDeliveryState = Convert.ToString(textBox.Text);
            //processing
            strDeliveryState = strDeliveryState.ToUpper();


            //if (rdoDelivery.Checked) //if delivery is checked
            //{
            if (strDeliveryState == "TEXAS" || strDeliveryState == "TX")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your state must be Texas in order to qualify for delivery.", "Delivery Address Error");
                return false;
            }
        }
        

    }
}
