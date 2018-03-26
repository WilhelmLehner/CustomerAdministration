using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLib;
//

namespace CostumerLogin_Wfm
{

    public partial class FrmTop : Form //Main window of the programm, contains information about the customer data and allows adding and editing of customers
    {
        #region Member variables
        private List<Customer> listCustomer = new List<Customer>();
        #endregion

        #region Constructor
        public FrmTop()
        {
            InitializeComponent();
            this.listCustomer = Customer.LoadListOfAllCustomers();      //filling the variable listCustomers with all existing Customers
            UpdateDataList();      //Updating the data grid view in the forms for illustrating all existing customers.
    
        }
        #endregion

        #region Private member methods
        /// <summary>
        /// Button "btnAddCustomer" opens the subwindow "FrmAddEditCust" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)      
        {
            FrmAddEditCust dialog = new FrmAddEditCust();   //Calling the subwindow "FrmAddEditCust" for adding customers

            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                listCustomer = Customer.LoadListOfAllCustomers(); //If the adding process in the subwindow "FrmAddEditCust" was successfull                                                
                UpdateDataList();                                 //the list gets updated again to upload the new customer in the data grid view. 
            }
            

        }


        /// <summary>
        /// Button to get the data from the current selected customer in the data grid view and writes it on the variable "currentSelectedCustomer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            Customer currentSelectedCustomer =
                Customer.GetCustomerWithNumber
                (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString()));  


            FrmAddEditCust dialog = new FrmAddEditCust(currentSelectedCustomer);    //Calling the subwindow "FrmAddEditCust" for editing customers 
                                                                                    //transfers the current selected customer into the subwindow for editing the E-Mail and the last name 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listCustomer = Customer.LoadListOfAllCustomers();   //If the editing process in the subwindow "FrmAddEditCust" was successfull 
                UpdateDataList();                                   //the list gets updated again to upload the edited customer in the data grid view.
            }
        }




        /// <summary>
        /// Button "btnMonayPayIn" adds money to the balance of the selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoneyPayIn_Click(object sender, EventArgs e)                        
        {
            Customer currentSelectedCustomer =
              Customer.GetCustomerWithNumber
              (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString())); //Gets the data from the current selected customer in the data grid view and writes it on the variable "currentSelectedCustomer"

            currentSelectedCustomer.AddMoneyPaid(Convert.ToDouble(this.nudValue.Value));  //Using the function "AddMoneyPaid" from the class "Customer" for adding money into the balance of the current selected customer
                                                                                          //The amount is taken out of the numeric up and down box "nudValue" 
            listCustomer = Customer.LoadListOfAllCustomers();
            UpdateDataList();                                                             //Updating of the list with the new balance value of the selected customer
        }


        /// <summary>
        /// Button "btnMonayPayOut" reduces money in the balance of the selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoneyPayOut_Click(object sender, EventArgs e)  
        {
            Customer currentSelectedCustomer =
              Customer.GetCustomerWithNumber
              (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString())); //Gets the data from the current selected customer in the data grid view and writes it on the variable "currentSelectedCustomer"

            currentSelectedCustomer.AddMoneyOwed(Convert.ToDouble(this.nudValue.Value)); //Using the function "AddMoneyOwed" from the class "Customer" for reducing money in the balance of the current selected customer
                                                                                         //The amount is taken out of the numeric up and down box "nudValue" 

            listCustomer = Customer.LoadListOfAllCustomers();
            UpdateDataList();                                                           //Updating of the list with the new balance value of the selected customer

        }



        /// <summary>
        /// Textbox "tbxEntry" is used to search for a customer in the list. An event is triggered when something changes in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxEntry_TextChanged(object sender, EventArgs e)      
        {
           this.listCustomer = Customer.ReturnListOfCustomerWhichIncludeStringInNames(this.tbxEntry.Text); //Uploads a list with the customers which contain the written text in the textbox "tbxEntry"
            this.UpdateDataList();
          
        }
        #endregion 

        #region static Methods 
        /// <summary>
        /// //static method for uploading every current existing customer into the data grid view
        /// </summary>
        private void UpdateDataList()       
        {
            dgvListCustomer.Rows.Clear();
            foreach (Customer element in this.listCustomer)
            {
                dgvListCustomer.Rows.Add(element.CustomerNumber, element.FirstName, element.LastName, element.EmailAddress, element.Balance, element.DateLastChange.ToShortTimeString());
            }

        }
        #endregion
    }
}
