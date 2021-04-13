// Author:          Kyle Chapman
// Last Modified:   March 11, 2021
// Description:
//  Demo program for NETD 2202 based off of Class Exercise 4 in 2021.
//  Meant as an aid for Lab 4. Using an existing Customer class, this
//  Windows form can display a list of customers and allow the user
//  to add new customers to the list as well as edit existing customers
//  selected from a ListView.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CustomerViewer
{
    public partial class formCustomerEntry : Form
    {
        private List<Car> carList = new List<Car>();
        // This flag is used to indicate whether the program is checking boxes as opposed to a human.
        private bool isAutomated = false;
        // Variable representing the current selected index in the ListView.
        // This is being used to simplify a few reference to indexes.
        private int selectedIndex = -1;

        public formCustomerEntry()
        {
            InitializeComponent();
        }

        #region "Event Handlers"

        /// <summary>
        /// When the form loads, instantiate some customers and add them to a list so they can be viewed later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            // Declare and instantiate five new customer objects.
            //// You are going to be asked to change some of these values.
            //Car kyle = new Car("Mr.", "Kyle", "Chapman", true);
            //// everyoneIsImportant -> whatever
            //Car everyoneIsImportant = new Car("Lady", "Scape", "Goat", false);
            //Car sixthCustomer = new Car("Lucky", "Number", "Six", true);

            //// Add all of the new customer objects from above to the list.
            //carList.Add(kyle);
            //carList.Add(everyoneIsImportant);
            //carList.Add(sixthCustomer);

            PopulateListView(carList);
        }

        /// <summary>
        /// Validate all input fields, and if they are valid create the customer object, add the entered customer to the list, and add them to the ListView.
        /// </summary>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Empty the error label; it will fill with NEW errors if anything is wrong.
            labelError.Text = String.Empty;

            // Check if the customer is valid.
            if (IsCarValid(comboBoxMake.Text, textBoxModel.Text, comboBoxYear.Text,textBoxPrice.Text))
            {
                // Customer details are valid; create a customer object.
                Car newCarToAdd = new Car(comboBoxMake.Text, textBoxModel.Text,Convert.ToInt32(comboBoxYear.Text), Convert.ToDecimal(textBoxPrice.Text), newStatus.Checked);

                // If a customer is currently selected...
                if (selectedIndex >= 0)
                {
                    // Replace the old version of that customer with the new one!
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    // Otherwise, add a customer with the entered details to the end of the list.
                    carList.Add(newCarToAdd);
                }

                // Refresh the entire listView.
                PopulateListView(carList);

                // Reset the form to allow new entries.
                SetDefaults();
            }
        }

        /// <summary>
        /// Reset the form to its default state.
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Me close form.
        /// </summary>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// When a customer in the ListView is selected, write that customer's properties into the input controls.
        /// </summary>
        private void CarSelected(object sender, EventArgs e)
        {
            // If the list is populated and something is selected...
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {
                // ...fill in the entry fields with values based on the selected customer.
                comboBoxMake.Text = listViewEntries.FocusedItem.SubItems[1].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                comboBoxYear.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                newStatus.Checked = listViewEntries.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewEntries.FocusedItem.Index;
            }
            else
            {
                // If nothing is selected, set the selectedIndex to -1.
                selectedIndex = -1;
            }
        }

        /// <summary>
        /// When a checkbox in the ListView is checked, say no and don't let the user change it.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        #endregion
          #region "Functions"

        /// <summary>
        /// Converts the customer passed in to a ListViewItem and adds it to listViewEntries
        /// </summary>
        /// <param name="newCar"></param>
        private void PopulateListView(List<Car> customerList)
        {
            // Clear the listView to start re-populating it.
            listViewEntries.Items.Clear();

            foreach (Car newCar in carList)
            {
                // Declare and instantiate a new ListViewItem.
                ListViewItem carItem = new ListViewItem();

                // Allow the program to modify the ListView's checkboxes.
                isAutomated = true;
                carItem.Checked = newCar.NewStatus;

                carItem.SubItems.Add(newCar.Id.ToString());
                carItem.SubItems.Add(newCar.make);
                carItem.SubItems.Add(newCar.model);
                carItem.SubItems.Add(newCar.year.ToString());
                carItem.SubItems.Add(newCar.price.ToString("S,#,0.00"));


                labelError.Text += "It works";
                // Add the customerItem to the ListView.
                listViewEntries.Items.Add(carItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;
            }
        }

        /// <summary>
        /// Reset the form's input fields to their default states.
        /// </summary>
        private void SetDefaults()
        {
            // Resets fields to default state.
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            textBoxPrice.Clear();
            comboBoxYear.SelectedIndex = -1;
            newStatus.Checked = false;
            listViewEntries.SelectedItems.Clear();
            labelError.Text = String.Empty;
            selectedIndex = -1;

            // Set a default focus.
            comboBoxMake.Focus();
        }

        /// <summary>
        /// Checks whether the input related to a car is valid
        /// </summary>
        /// <param name="make">The car's title as a string</param>
        /// <param name="model">The car's model as a string</param>
        /// <param name="year">The car's year as a string</param>
        /// <returns></returns>
        private bool IsCarValid(string make, string model, string year, string price)
        {
            // Assume the worker is valid.
            bool isValid = true;

            // Check the first input.
            if (make == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must select a make of car.\n";
            }
            // Check the second input.
            if (model == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must enter a model of a car.\n";
            }
            // Check the third input.
            if (year == "")
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must enter a valid year.\n";
            }
            // Check the fourth input.
            if (price == String.Empty) 
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelError.Text += "You must enter a valid price.";
            }


            return isValid;
        }

        #endregion

        
    }
}
