using ISYS250HW;
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
//FORM: frmVendor
//PURPOSE: This program is designed to allow access to the vendor information.
//The user is able to tab back and forth between each vendor file using next
//and previous buttons. The user has the ability to change the data and save it.
//INPUT: The given information on the vendor as well as the new information
//entered by the user.
//PROCESS: Takes the vendors information displays it on the form and
//then allows for the user to edit it wherever they choose to.
//OUTPUT: The updated information of the vendors.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

namespace ISTM250Project1
{
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        string[] strDiscount = { "10", "15", "20" };

        int intCount = 0;
        bool boolNextVendor = true; 
        private List<Vendor> vendors = null;
        private Vendor vendor;

        /// <summary>
        /// Populates the textboxes with vendor info
        /// </summary>
        private void FillVendorTextBox()
        {
            int i = intCount; //sets i equal to the global count which is updated as we click through vendors
            //populates textboxes with vendor information
            txtVName.Text = vendors[i].Name;
            txtVAddress.Text = vendors[i].Address;
            txtVCity.Text = vendors[i].City;
            txtVState.Text = vendors[i].State;
            txtVZip.Text = vendors[i].Zip;
            txtVPhone.Text = vendors[i].Phone;
            txtVSales.Text = vendors[i].YTD.ToString();
            txtVRep.Text = vendors[i].Contact;
            txtVComments.Text = vendors[i].Comment;
            
            if(vendors[i].DefaultDiscount.ToString() =="10") // sets the first value in combo box to 10
            {
                cboDiscount.SelectedIndex = 0;
            }
            else if (vendors[i].DefaultDiscount.ToString() == "15") // sets the second value in combo box to 15
            {
                cboDiscount.SelectedIndex = 1;
            }
            else if (vendors[i].DefaultDiscount.ToString() == "20") // sets the third value in combo box to 20
            {
                cboDiscount.SelectedIndex = 2; 
            }
            boolNextVendor = true; //User can go to next vendor
        }

        

        /// <summary>
        /// this checks to see if the data is valid
        /// </summary>
        /// <returns></returns>
        private bool IsDataValid()
        {
            if (cboDiscount.SelectedIndex == -1) //if a default discount is not selected
            {
                MessageBox.Show("Please select a default discount", "Default Discount Error");
                return false; //data is not valid
            }
            else
            {
                //check if data in textboxes is valid
                return
                    Validator.IsPresent(txtVName, "Vendor Name") &&
                    Validator.IsPresent(txtVAddress, "Vendor Address") &&
                    Validator.IsPresent(txtVCity, "Vendor City") &&
                    Validator.IsPresent(txtVState, "Vendor State") &&
                    Validator.IsPresent(txtVZip, "Vendor Zip Code") &&
                    Validator.IsPresent(txtVSales, "Vendor YTD Sales") &&
                    Validator.IsPresent(txtVRep, "Contact") &&
                    Validator.IsPresent(txtVPhone, "Vendor Phone Number") &&
                    Validator.IsInteger(txtVPhone, "Vendor Phone Number");
            }
            
        }

        /// <summary>
        /// Saves the data
        /// </summary>
        private void SaveData() 
        {
            vendor = VendorChange(); //sets vendor values to current vendor values
            vendors[intCount] = vendor;
            VendorDB.SaveVendors(vendors);
            boolNextVendor = true; //eligible to view a different vendor

        }

        /// <summary>
        /// Goes to the next vendor file
        /// If we are at the end of the vendor files, we will go back to the beginning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (IsDataValid()) //if data is valid
            {

                if (boolNextVendor == true) //if you are eligible to go to a different vendor
                {

                    if (intCount == 5) //if we have reached the last vendor
                    {
                        intCount = 0; //we go back to the first vendor
                    }
                    else
                    {
                        intCount++; //go to the next vendor
                    }

                    FillVendorTextBox();
                    boolNextVendor = true;
                }
                else
                {
                    DialogResult button = MessageBox.Show("Would you like to save your data?", "Save Data", MessageBoxButtons.YesNoCancel); //prompt the user asking if they want to save their data changes
                    if (button == DialogResult.Yes) //if they want to save their changes
                    {
                        SaveData(); //save the data
                        if (intCount == 5) //if we have reached the last vendor
                        {
                            intCount = 0; //we go back to the first vendor
                        }
                        else
                        {
                            intCount++; //go to the next vendor
                        }
                    }
                    else if (button == DialogResult.No)
                    {
                        if (intCount == 5) //if we have reached the last vendor
                        {
                            intCount = 0; //we go back to the first vendor
                        }
                        else
                        {
                            intCount++; //go to the next vendor
                        }
                    }
                    FillVendorTextBox(); //repopulate text boxes on form with new vendor information
                    boolNextVendor = true; //eligible to view a different vendor
                }
            }
        }
        /// <summary>
        /// Goes to previous vendor file. If we have reached the beginning of the
        /// vendors, the method will take us to the end again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (IsDataValid()) //checks if data is valid
            {
                if (boolNextVendor == true) //checks that data is saved and that
                                            //you made proceed to a different vendor
                {
                    if (intCount == 0) //if we are at the beginning, 
                    {
                        intCount = 5; //we will go back to the end
                    }
                    else
                    {
                        // move count back one vendor to take us to previous
                        intCount--;
                    }

                    FillVendorTextBox(); //repopulate the textboxes on the form
                                         //to show previous vendor
                    boolNextVendor = true;
                }
                else
                {
                    DialogResult button = MessageBox.Show("Would you like to save your data?", "Save Data", MessageBoxButtons.YesNoCancel); //prompt the user asking if they want to save their data changes
                    if (button == DialogResult.Yes) //if they want to save their changes
                    {
                        SaveData(); //save data
                        if (intCount == 0) //if we are at the beginning, 
                        {
                            intCount = 5; //we will go back to the end
                        }
                        else
                        {
                            intCount--; //go to previous vendor record
                        }
                        
                    }
                    else if (button == DialogResult.No)
                    {
                        //don't save data
                        if (intCount == 0) //if we are at the beginning, 
                        {
                            intCount = 5; //we will go back to the end
                        }
                        else
                        {
                            intCount--; //go to previous vendor record
                        }
                    }

                    FillVendorTextBox(); //repopulate text boxes on form to show
                                         //vendor data of previous vendor record
                    boolNextVendor = true;
                }
            }
        }

        /// <summary>
        /// Adds vendor information to the vendor class
        /// </summary>
        public Vendor VendorChange()
        {
            int intSelectedIndex = 0; // checks that discount is selected
            if (vendors[intCount].DefaultDiscount.ToString() == "10")
            {
                intSelectedIndex = 10;
            }
            else if (vendors[intCount].DefaultDiscount.ToString() == "15")
            {
                intSelectedIndex = 15;
            }
            else if (vendors[intCount].DefaultDiscount.ToString() == "20")
            {
                intSelectedIndex = 20;
            }
            vendor = new Vendor(txtVName.Text, txtVAddress.Text, txtVCity.Text, txtVState.Text, txtVZip.Text, txtVPhone.Text, Convert.ToDecimal(txtVSales.Text), txtVRep.Text, txtVComments.Text, intSelectedIndex);

            return vendor;
        }

        /// <summary>
        /// Saves the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid()) //if the data is valid
            {
                SaveData(); //save the data
            }
        }

        /// <summary>
        /// Loads vendor info into the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVendor_Load(object sender, EventArgs e)
        {
            foreach (string defaultDiscount in strDiscount)
            {
                cboDiscount.Items.Add(defaultDiscount); //loads combo box values from string array strDiscount
            }
            vendors = VendorDB.GetVendors();
            FillVendorTextBox();
            boolNextVendor = true; //user can go to next vendor 
        }

        /// <summary>
        /// closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  If user changes combobox they shouldn't be able to go to next vendor, this validates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            boolNextVendor = false; //NOT eligible to view a different vendor
        }

        /// <summary>
        /// If textbox changes user shouldn't be able to go to next vendor, this validates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtVState_TextChanged(object sender, EventArgs e)
        {
            boolNextVendor = false; //NOT eligible to view a different vendor
        }
        
    }
}
