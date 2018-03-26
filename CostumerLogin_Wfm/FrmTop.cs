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

namespace CostumerLogin_Wfm
{

    public partial class FrmTop : Form //Main window of the programm, contains information about the customer data and allows adding and editing of customers
    {
        #region Member variables
        private List<Customer> listCustomer = new List<Customer>();
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor of main window
        /// </summary>
        public FrmTop()
        {
            InitializeComponent();
            UpdateDataList();      //Updating the data grid view in the forms for illustrating all existing customers.
    
        }
        #endregion

        #region Private member methods
        /// <summary>
        /// //static method for uploading every current existing customer into the data grid view
        /// </summary>
        private void UpdateDataList()
        {
            //Clear display
            dgvListCustomer.Rows.Clear();

            //Update liste
            if (String.IsNullOrWhiteSpace(tbxEntry.Text)) this.listCustomer = Customer.LoadListOfAllCustomers();
            else this.listCustomer = Customer.ReturnListOfCustomerWhichIncludeStringInNames(tbxEntry.Text);

            //Update display
            foreach (Customer element in this.listCustomer)
            {
                dgvListCustomer.Rows.Add(element.CustomerNumber, element.FirstName, element.LastName, element.EmailAddress, string.Format("{0:0.00}", element.Balance), element.DateLastChange.ToShortDateString());
            }
        }

        /// <summary>
        /// //static method for uploading every current existing customer into the data grid view and selecting the currently selected customer
        /// </summary>
        private void UpdateDataList(Customer currentlySelectedCustomer)
        {
            //UpdateDataList
            UpdateDataList();

            //Select the currently selected Customer
            for (int i = 0; i < this.dgvListCustomer.Rows.Count; i++)
            {
                if (Int32.Parse(this.dgvListCustomer.Rows[i].Cells[0].Value.ToString()) == currentlySelectedCustomer.CustomerNumber)
                {
                    this.dgvListCustomer.Rows[i].Selected = true;
                    break;
                }
            }
        }
        #endregion

        #region Private event methods
        /// <summary>
        /// Button "btnAddCustomer" opens the subwindow "FrmAddEditCust" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)      
        {
            FrmAddEditCust dialog = new FrmAddEditCust(); //Calling the subwindow "FrmAddEditCust" for adding customers

            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                tbxEntry.Text = string.Empty;
                UpdateDataList(dialog.ACustomer); //the list gets updated again to upload the new customer in the data grid view. 
                this.dgvListCustomer.FirstDisplayedScrollingRowIndex = dgvListCustomer.RowCount - 1;
            }
        }


        /// <summary>
        /// Button to get the data from the current selected customer in the data grid view and writes it on the variable "currentSelectedCustomer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (this.dgvListCustomer.SelectedCells.Count != 0)
            {
                Customer currentSelectedCustomer =
                Customer.GetCustomerWithNumber
                (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString()));


                FrmAddEditCust dialog = new FrmAddEditCust(currentSelectedCustomer);    //Calling the subwindow "FrmAddEditCust" for editing customers 
                                                                                        //transfers the current selected customer into the subwindow for editing the E-Mail and the last name 
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataList(currentSelectedCustomer);            //the list gets updated again to upload the edited customer in the data grid view.
                }
            }
            else
            {
                MessageBox.Show("There is no customer selected, who can be changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UpdateDataList(currentSelectedCustomer);                                                             //Updating of the list with the new balance value of the selected customer
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

            currentSelectedCustomer.AddMoneyOwed(Convert.ToDouble(this.nudValue.Value)); //Using the function "AddMoneyOwed" from the class "Customer" for reducing money in the balance of the current selected customer. The amount is taken out of the numeric up and down box "nudValue" 

            UpdateDataList(currentSelectedCustomer);                                                           //Updating of the list with the new balance value of the selected customer

        }


        /// <summary>
        /// Textbox "tbxEntry" is used to search for a customer in the list. An event is triggered when something changes in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxEntry_TextChanged(object sender, EventArgs e)      
        {
            //Update display
            this.UpdateDataList();
        }

        /// <summary>
        /// The size of the data grid view and the position of the groupbox elements are adjusted according to the size of the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTop_SizeChanged(object sender, EventArgs e)
        {
            //change size of data grid view
            this.dgvListCustomer.Width = this.Width - 200;
            this.dgvListCustomer.Height = this.Height - 60;

            //chang position of groupbox elements
            this.gbxCustomer.Location = new Point(this.Width - 185, this.gbxCustomer.Location.Y);
            this.gbxSearch.Location = new Point(this.Width - 185, this.gbxSearch.Location.Y);
            this.gbxBalance.Location = new Point(this.Width - 185, this.gbxBalance.Location.Y);
        }
        #endregion

        private void dgvListCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListCustomer.SelectedCells.Count == 0)
            {
                gbxSearch.Enabled = false;
                gbxBalance.Enabled = false;
            }
            else
            {
                gbxSearch.Enabled = true;
                gbxBalance.Enabled = true;
            }
        }
    }
}
