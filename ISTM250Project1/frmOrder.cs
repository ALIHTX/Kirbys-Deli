using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHOR: Rachel Navara, Ali Noorani, Claire Rose, Muhab Elkaraty
//COURSE: ISTM 250.501
//FORM: frmOrder
//PURPOSE: This program is designed to record sandwich and pizza orders from a user
// keeping track of the order and quantity ordered to be displayed in a listbox.
// It will be able to add additional different orders, keeping a subtotal and then a combined cost total
// It will clear the order information when adding to the order and clear everything when pressing clear.
// It will also ask if you want to save if you try closing the form and then it will save if you proceed to completion.
// The deli clerk will be able to choose from different combo boxes based on the selection of the previous combo boxes the
// type of sandwich/pizze the customer wishes to have. Lastly it will provide a carry out or delivery option, thus requiring the
// customer to input their name and address. The delivery address will only be within a certain range otherwise your order won't be completed.
//INPUT: The customer name, address, checking of delivery or carry out,
// item type, various item selections within the combo boxes, and a quantity must be inputted.
//PROCESS: Items added to the combo boxes based on whether or not customer selects pizza or sandwich. Orders stored in list box and added when
// user adds to order or completes it. Groupbox for delivery becomes active when user presses delivery radio box and copies customer
// information over to delivery groupbox. Asks user if they want to exit the form if they press close button, cancel, or exit form. Sets boolOrderComplete to
// true if user clicks Order Complete button. Clears all data in form when user clicks clear. Validates customer information is present, correct format, within range,
// and that the combo boxes have something selected. Shows picture of food based on the selection made in item combo box.
//OUTPUT: The delivery groupbox will be activated if that specific radio button is selected outputting the copied customer information
// from the customer groupbox. The listbox will show the item the customer makes and the quantity for each different item type.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”


namespace ISTM250Project1
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }




        /// <summary>
        /// If the delivery radio button is clicked, all the customer information is pasted to the delivery textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDelivery.Checked) //if radio button for delivery is clicked
            {
                gboDelivery.Enabled = true;  //groupbox for delivery becomes activated
                txtDeliveryName.Text = txtCustomerName.Text; //Copies customer name to delivery name
                txtDeliveryStreet.Text = txtCustomerStreet.Text;  //Copies customer street to delivery street
                txtDeliveryCity.Text = txtCustomerCity.Text;  //Copies customer city to delivery city
                txtDeliveryState.Text = txtCustomerState.Text; //Copies customer state to delivery state
                txtDeliveryZip.Text = txtCustomerZip.Text; //Copies customer zip to delivery zip
                txtDeliveryPhone.Text = txtCustomerPhone.Text; //Copies customer phone to delivery phone
                txtDeliverySubdivision.Text = txtCustomerSubdivision.Text; //Copies customer subdivision to delivery subdivision
                txtDeliveryName.Focus(); //turns focus back to delivery name
            }
            else
            {
                gboDelivery.Enabled = false; //delivery radio button isn't clicked so delivery groupbox remains deactivated
            }
        }

        string[] strItems = { "Sandwich", "Pizza" }; //Creates string array for items pizza and sandwich
        string[] strSpecialtySandwiches = { "Ham and Swiss", "Turkey and Provolone", "BLT" }; //Creates string array for specialty sandwiches
        string[] strSpecialtyPizzas = { "Med Cheese Pizza", "Med Pepperoni Pizza", "Med Supreme Pizza" }; //Creates string array for specialty pizzas
        string[] strBread = { "White", "Pumpernickel", "Rye", "Sourdough", "Multigrain" };  //Creates string array for bread types
        string[] strCrust = { "Original", "Pan", "Thin", "Wheat" };  //Creates string array for crust types
        public static bool boolOrderComplete = false;  //declares boolean variable for order complete

        private void cboSpecialtyItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the form loads the combo boxes will have items to choose from according to their string array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_Load(object sender, EventArgs e)
        {
            gboDelivery.Enabled = false; //delivery groupbox is deactivate when the form loads
            foreach (string strItem in strItems)
            {
                cboItem.Items.Add(strItem); //Adds items from the string item array to be inputted in the item combo box
            }
            foreach (string strSpecialtySandwich in strSpecialtySandwiches)
            {
                cboSpecialtyItem.Items.Add(strSpecialtySandwich); //Adds specialty sandwiches from the string specialty sandwich array to be inputted in the specialty item combo box
            }
            foreach (string strSpecialtyPizza in strSpecialtyPizzas)
            {
                cboSpecialtyItem.Items.Add(strSpecialtyPizza); //Adds specialty pizzas from the string specialty pizza array to be inputted in the specialty item combo box
            }

        }

        //creates and initializes decimal variables to 0
        public decimal decPrice = 0m;
        public static decimal decQuantity = 0m;
        
        decimal decSubtotal = 0m;
        decimal decTotal = 0m;
        //creates tax variable and sets it to equal a rate of 8.25%
        decimal decTax = 0.0825m;
        public decimal decQ = 1m;
        public static int selectedIndex = 0;
        public static int specialtyItem = 0;
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
                    //clear contents on form for a new item to be added
                    //do not clear complete order or subtotals

                    decQuantity = Convert.ToInt32(txtQuantity.Text);
                    decQ = decQuantity;

                    int intItem = cboItem.SelectedIndex; //holds the value of the combo box index
                    int intBreadCrust = cboBreadCrust.SelectedIndex; //holds the value of the combo box index
                    int intSpecialtyItem = cboSpecialtyItem.SelectedIndex; //holds the value of the combo box index
                    string strBreadCrust = ""; //creates a string for bread or crust type and initalizes it to nothing
                    string strSpecialtyItem = ""; //creates a string for specialty item type and initializes it to nothing
                    
                    if (intItem == 0) //sandwich
                    {
                        strBreadCrust = strBread[intBreadCrust]; //what type of bread
                        strSpecialtyItem = strSpecialtySandwiches[intSpecialtyItem]; //what type of specialty sandwich
                    }
                    else
                    {
                        //pizza
                        strBreadCrust = strCrust[intBreadCrust]; //what type of crust
                        strSpecialtyItem = strSpecialtyPizzas[intSpecialtyItem]; //what type of specialty pizza
                    }

                    //decQuantity = Convert.ToDecimal(txtQuantity.Text);

                    //frmInventory frmInventory1 = new frmInventory();

                    //frmInventory1.AdjustInventory();

                    if (cboItem.SelectedIndex == 0)
                    {
                        decPrice = 5.00m; //item price for sandwich
                        
                        selectedIndex = cboItem.SelectedIndex;
                    }
                    else if (cboItem.SelectedIndex == 1)
                    {
                        decPrice = 9.50m; //item price for pizza
                        selectedIndex = cboItem.SelectedIndex;

                    }

                    decSubtotal = decQuantity * decPrice; //calculates subtotal for item
                    //add tax
                    decimal decSubtotalTax = decSubtotal * decTax;
                    decTotal = decTotal + decSubtotal + decSubtotalTax; //adds item subtotal and tax to order total
                    //frmInventory frmInventory1 = new frmInventory();

                    //frmInventory1.AdjustInventory();


                    specialtyItem = cboSpecialtyItem.SelectedIndex;
                    cboItem.SelectedIndex = -1; //resets combo box to no selection
                    cboSpecialtyItem.SelectedIndex = -1; //resets combo box to no selection
                    cboBreadCrust.SelectedIndex = -1; //resets combo box to no selection
                    txtQuantity.Text = ""; //clears quantity text box
                    pboDeliPicture.Visible = false; //shows sandwich picture
                    pboPizzaPicture.Visible = false; //hides pizza picture

                    string strOrder = strBreadCrust + " " + strSpecialtyItem + ", " + decQuantity + "@$" + decPrice + ", " + "total: $" + decSubtotal; //creates a string to display item and subtotal in list box
                    lstYourOrder.Items.Add(strOrder); //adds the string to the list box
                    //txtOrderTotal.Text = decTotal.ToString("c");

        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            

            Close();
        }

        /// <summary>
        /// When the user tries closing form, they are asked if they wish to save, not save, or cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (boolOrderComplete == false)//if there is unsaved data on the form.
            {
                DialogResult button = MessageBox.Show("Are you sure you want to exit the order form? This cannot be undone.", "Complete Order?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//this message box will have more options than just ok.

                if (button == DialogResult.No)
                {
                    e.Cancel = true; //does not close the form; we would save the data to the server (but we don't have a server in this project)
                }

                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

                //if button = Yes, let form close
            }
        }

        /// <summary>
        /// This validates that all the data is complete and correct, then sets the boolean order complete to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {

            //if (rdoDelivery.Checked && Validation.IsOrderProcessed(boolIsOrderProcessed))
            //{
            //    // this first checks to see the information is valid
            //    if (IsCustomerInfoValid())
            //    {
            //        // if it is valid, this message box will show up
            //        MessageBox.Show("Thanks for ordering from Kirby's Deli!", "Order Complete");
            //        // this resets the form
            //        ResetForm();
            //    }

            try
            {
                if (IsValidData())
                {
                    boolOrderComplete = true;


                    lstYourOrder.Items.Clear();
                    cboItem.SelectedIndex = -1;
                    cboSpecialtyItem.SelectedIndex = -1;
                    cboBreadCrust.SelectedIndex = -1;
                    txtQuantity.Text = "";
                    pboDeliPicture.Visible = false; //shows sandwich picture
                    pboPizzaPicture.Visible = false; //hides pizza picture

                    decSubtotal = decQuantity * decPrice; //calculates subtotal for item
                                                          //add tax
                    //decimal decSubtotalTax = decSubtotal * decTax;
                    //decTotal = decTotal + decSubtotal + decSubtotalTax;
                    //decimal decTotalTax = decTotal * decTax;
                    //decTotal += decTotalTax;
                    txtOrderTotal.Text = decTotal.ToString("c");

                    decTotal = 0;
                    decSubtotal = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString()); //Message that shows for if any other exception occurs that aren't any of the ones above
            }

        }

        /// <summary>
        /// Clears the input of the order information as if the user is starting over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            //since the instructions said to clear "all text fields" we are going to clear the customer info as well
            //clearing customer fields
            txtDeliveryCity.Text = "";
            txtDeliveryName.Text = "";
            txtDeliveryPhone.Text = "";
            txtDeliveryState.Text = "";
            txtDeliveryStreet.Text = "";
            txtDeliverySubdivision.Text = "";
            txtDeliveryZip.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerState.Text = "";
            txtCustomerStreet.Text = "";
            txtCustomerSubdivision.Text = "";
            txtCustomerZip.Text = "";

            //clearing order fields
            lstYourOrder.Items.Clear();  //clears list with orders
            cboItem.SelectedIndex =-1; //resets item combo box to no selection
            cboSpecialtyItem.SelectedIndex = -1;  //resets item combo box to no selection
            cboBreadCrust.SelectedIndex = -1;  //resets item combo box to no selection
            txtQuantity.Text = ""; //Clears quantity textbox
            txtOrderTotal.Text = "";
            decSubtotal = 0;
            decTotal = 0;
        }
        #region Old Validation
        /// <summary>
        /// Declares method for if certain criteria is present
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool IsPresent(TextBox textBox, string name)
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
        /// <param name="comboBox"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool IsSelected(ComboBox comboBox, string name)
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
        private bool IsInteger(TextBox textBox, string name)
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
        /// <param name="strCityOne"></param>
        /// <param name="strCityTwo"></param>
        /// <returns></returns>
        private bool IsWithinCityRange(TextBox textBox, string strCityOne, string strCityTwo)
        {

            //input
            string strDeliveryCity = Convert.ToString(txtDeliveryCity.Text);
            string strDeliveryState = Convert.ToString(txtDeliveryState.Text);
            
            //procressing
            strDeliveryCity = strDeliveryCity.ToUpper();
        
            if (rdoDelivery.Checked)
            {
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
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Validates Texas is the state that is chosen for delivery
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="strState"></param>
        /// <returns></returns>
        private bool IsWithinStateRange(TextBox textBox, string strState)
        {
            //input
            string strDeliveryState = Convert.ToString(txtDeliveryState.Text);
            //processing
            strDeliveryState = strDeliveryState.ToUpper();
            if (rdoDelivery.Checked) //if delivery is checked
            {
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
            else //if delivery is not checked no validation run on city
            {
                return true;
            }
        }
        #endregion
        #region newValidation
        /// <summary>
        /// Declares method that validates that all the returning methods are true
        /// </summary>
        /// <returns></returns>
        private bool IsValidData() // Is valid if all of these are returned as true
        {

            if (rdoDelivery.Checked)
            {
                //validate customer, delivery, and order fields
                return
                Validator.IsPresent(txtDeliveryName, "Delivery Name") && //Customer Name is present
                Validator.IsPresent(txtDeliveryStreet, "Delivery Street") && //Customer street is present
                Validator.IsPresent(txtDeliveryCity, "Delivery City") && //Customer city is present
                Validator.IsPresent(txtDeliveryState, "Delivery State") && //Customer state is present
                Validator.IsPresent(txtDeliveryZip, "Delivery Zip") && //Customer zip is present
                Validator.IsPresent(txtDeliveryPhone, "Delivery Phone") && //Customer phone number is present
                Validator.IsPresent(txtCustomerName, "Customer Name") && //Customer Name is present
                Validator.IsPresent(txtCustomerStreet, "Customer Street") && //Customer street is present
                Validator.IsPresent(txtCustomerCity, "Customer City") && //Customer city is present
                Validator.IsPresent(txtCustomerState, "Customer State") && //Customer state is present
                Validator.IsPresent(txtCustomerZip, "Customer Zip") && //Customer zip is present
                Validator.IsPresent(txtCustomerPhone, "Customer Phone") && //Customer phone number is present
                Validator.IsSelected(cboItem, "Item Selection") && //Item combo box is selected
                Validator.IsSelected(cboSpecialtyItem, "Specialty Item") && //Specialty item is selected
                Validator.IsSelected(cboBreadCrust, "Crust Option") && //Crust combo box is selected
                Validator.IsPresent(txtQuantity, "Order Quantity") && //Quantity is present
                Validator.IsInteger(txtQuantity, "Order Quantity") &&  //Quantity is an integer
                Validator.IsInteger(txtCustomerPhone, "Customer Phone Number") && //Phone is and integer
                Validator.IsInteger(txtDeliveryPhone, "Delivery Phone Number") && //Phone is and integer
                Validator.IsInteger(txtCustomerZip, "Customer Zip Code") && //zip code is an integer
                Validator.IsInteger(txtDeliveryZip, "Delivery Zip Code") && //zip is an integer
                Validator.IsWithinCityRange(txtDeliveryCity) && //Delivery city is either College Station or Bryan
                Validator.IsWithinStateRange(txtDeliveryState); //Delivery state is Texas
            }
            else if (btnAddItem.Enabled)
            {
                //validate customer fields and order fields only
                return
                Validator.IsPresent(txtCustomerName, "Customer Name") && //Customer Name is present
                Validator.IsPresent(txtCustomerStreet, "Customer Street") && //Customer street is present
                Validator.IsPresent(txtCustomerCity, "Customer City") && //Customer city is present
                Validator.IsPresent(txtCustomerState, "Customer State") && //Customer state is present
                Validator.IsPresent(txtCustomerZip, "Customer Zip") && //Customer zip is present
                Validator.IsPresent(txtCustomerPhone, "Customer Phone") && //Customer phone number is present



                Validator.IsInteger(txtCustomerPhone, "Customer Phone Number") && //Phone is and integer
                Validator.IsInteger(txtCustomerZip, "Customer Zip Code"); //zip code is an integer
            }
            else
            {
                //validate customer fields and order fields only
                return
                Validator.IsPresent(txtCustomerName, "Customer Name") && //Customer Name is present
                Validator.IsPresent(txtCustomerStreet, "Customer Street") && //Customer street is present
                Validator.IsPresent(txtCustomerCity, "Customer City") && //Customer city is present
                Validator.IsPresent(txtCustomerState, "Customer State") && //Customer state is present
                Validator.IsPresent(txtCustomerZip, "Customer Zip") && //Customer zip is present
                Validator.IsPresent(txtCustomerPhone, "Customer Phone") && //Customer phone number is present
                Validator.IsSelected(cboItem, "Item Selection") && //Item combo box is selected
                Validator.IsSelected(cboSpecialtyItem, "Specialty Item") && //Specialty item is selected
                Validator.IsSelected(cboBreadCrust, "Crust Option") && //Crust combo box is selected
                Validator.IsPresent(txtQuantity, "Order Quantity") && //Quantity is present
                Validator.IsInteger(txtQuantity, "Order Quantity") &&  //Quantity is an integer
                Validator.IsInteger(txtCustomerPhone, "Customer Phone Number") && //Phone is and integer
                Validator.IsInteger(txtCustomerZip, "Customer Zip Code"); //zip code is an integer
            }
        }

        #endregion

        /// <summary>
        /// Outputs either sandwich or pizza type based on whether pizza or sandwich was selected in item combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItem.SelectedIndex == 0) //item selected is sandwich
            {
                cboSpecialtyItem.Items.Clear();
                cboBreadCrust.Items.Clear();
                foreach (string strSpecialtySandwich in strSpecialtySandwiches)
                {
                    cboSpecialtyItem.Items.Add(strSpecialtySandwich); //Adds specialty sandwiches from the string specialty sandwich array to be inputted in the specialty item combo box
                }
                foreach (string strBread in strBread)
                {
                    cboBreadCrust.Items.Add(strBread); //Adds bread types from the string bread array to be inputted in the bread crust combo box
                }
                pboDeliPicture.Visible = true; //shows sandwich picture
                pboPizzaPicture.Visible = false; //hides pizza picture
            }
            else if (cboItem.SelectedIndex == 1)  //item selected is pizza
            {
                cboSpecialtyItem.Items.Clear();
                cboBreadCrust.Items.Clear();
                foreach (string strSpecialtyPizza in strSpecialtyPizzas)
                {
                    cboSpecialtyItem.Items.Add(strSpecialtyPizza); //Adds specialty pizzas from the string specialty pizza array to be inputted in the specialty item combo box
                }
                foreach (string strCrust in strCrust)
                {
                    cboBreadCrust.Items.Add(strCrust); //Adds crust types from the string crust array to be inputted in the bread crust combo box
                }
                pboDeliPicture.Visible = false; //hides sandwich picture
                pboPizzaPicture.Visible = true; //shows pizza picture
            }
        }

        

        /// <summary>
        /// Clears delivery group box text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoCarryOut_CheckedChanged(object sender, EventArgs e)
        {
            //clears all text boxes in delivery group box if customer decides they want to carry out instead
            txtDeliveryCity.Text = "";
            txtDeliveryName.Text = "";
            txtDeliveryPhone.Text = "";
            txtDeliveryState.Text = "";
            txtDeliveryStreet.Text = "";
            txtDeliverySubdivision.Text = "";
            txtDeliveryZip.Text = "";
        }
        /// <summary>
        /// opens up inventory form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory1 = new frmInventory();

            frmInventory1.ShowDialog(); //opens up form with inventory levels
        }
        /// <summary>
        /// opens up vendor form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVendor_Click(object sender, EventArgs e)
        {
            frmVendor frmVendor1 = new frmVendor();

            frmVendor1.ShowDialog(); //opens up form with vendor levels
        }
    }
}
