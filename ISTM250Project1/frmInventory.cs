//current version

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
//PURPOSE: This program is designed to keep track of inventory levels for Kirby's Deli. As
//products are ordered by customers, inventory of deli ingredients are updated.
//INPUT: Item type, various item selections within the combo boxes, and a quantity must be inputted in order to obtain
//amount of products ordered. Customer information has been defaulted for ease of grading.
//PROCESS: Quantity of each product ordered results in a calculation of how many total ingredients will be needed to complete the order.
//Once this is calculated, inventory is decreased based on these numbers.
//OUTPUT: The updated inventory amounts are displayed to the lstInventory.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

namespace ISTM250Project1
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();   
        }


        //initial inventory is loaded into array
        string[] strIngredients = { "Flour", "Yeast", "Sugar", "Oil", "Ham", "Turkey", "SCheese", "Lettuce", "Tomato", "Bacon", "Pickles", "Mayo", "Mustard", "Pepperoni", "Sauce", "GCheese", "Salt", "Pepper" }; //item names
        decimal[] decInventory = { 200, 50, 30, 25, 10, 10, 20, 14, 14, 10, 20, 15, 12, 20, 60, 25, 10, 10 }; //item quantities


        //loading ingredients needed for products into array when program first runs
        decimal[,] decMeasurement = { {1m,1m,1m,3m,3m,3m}, //represents the quantity needed of each ingredient for each menu item
                                          {0.5m,0.5m,0.5m,2m,2m,2m},
                                          {0.03m,0.03m,0.03m,0.5m,0.5m,0.5m},
                                          {0.05m,0.05m, 0.05m,0.1m,0.1m,0.1m},
                                          {0.1m,0m,0m,0m,0m,0.1m},
                                          {0m,0.1m,0m,0m,0m,0.1m},
                                          {0.1m,0.1m,0m,0m,0m,0m},
                                          {0.25m,0.25m,0.3m,0m,0m,0m},
                                          {0.25m,0.25m,0.3m,0m,0m,0.3m},
                                          {0m,0m,0.1m,0m,0m,0.1m},
                                          {0.02m,0.02m,0m,0m,0m,0m},
                                          {0.02m,0.02m,0.02m,0m,0m,0m},
                                          {0.02m,0.02m,0.02m,0m,0m,0m},
                                          {0m,0m,0m,0m,0.3m,0.3m},
                                          {0m,0m,0m,1m,1m,1m},
                                          {0m,0m,0m,0.3m,0.2m,0.2m},
                                          {0.01m,0.01m,0.01m,0.02m,0.02m,0.02m},
                                          {0.01m,0.01m,0.01m,0.02m,0.02m,0.02m} };
        
        string[] strSpecialtyItems = { "Ham and Swiss", "Turkey and Provolone", "BLT", "Med Cheese Pizza", "Med Pepperoni Pizza", "Med Supreme Pizza" }; //menu items


        
        /// <summary>
        /// adjusts the inventory and then loads the new inventory according specialty items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInventory_Load(object sender, EventArgs e)
        {

            Decimal decAmount = frmOrder.decQuantity;



            for (int i = 0; i < decInventory.Length; i++)
            {
                if (frmOrder.selectedIndex == 0) // sandwich
                {
                    decInventory[i] -= decMeasurement[i, frmOrder.specialtyItem] * decAmount;
                }
                if (frmOrder.selectedIndex == 1) // pizza
                {
                    decInventory[i] -= decMeasurement[i, frmOrder.specialtyItem + 3] * decAmount;
                }


            }
            LoadInventory();
        }
       
        /// <summary>
        /// loads the inventory
        /// </summary>
        private void LoadInventory()
        {
            lstInventory.Items.Clear();
            for (int i = 0; i < strIngredients.Length; i++) //used to combine the ingredient name and quantity together in one string
            {
                string strInventory = strIngredients[i] + " " + decInventory[i] + "\n"; //creates a string for each ingredient and its quantity available
                lstInventory.Items.Add(strInventory); //adds the string to the list box
                
            }

            

        }
        
       

    }
}
