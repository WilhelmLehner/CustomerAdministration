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
    public partial class FrmAddEditCust : Form      //Subwindow of the main application. Provides the possibility of adding or editing customers. 
    {
        #region static variables
        private Customer aCustomer;
        private Customer currCustomer;
        private bool customerChange;
        #endregion 

        #region Cunstructor
        /// <summary>
        /// Public constructor to create a customer with the data of the current selected customer in the data grid view of the FrmTop.
        /// </summary>
        /// <param name="currentCustomer"></param>
        public FrmAddEditCust(Customer currentCustomer)     //Cunstroctor for editing customer
        {

            InitializeComponent();
            this.currCustomer = currentCustomer;
            this.tbxFirstName.Enabled = false;  //Enabling the textbox "tbxFirstName" for further changing
            this.tbxFirstName.Text = this.currCustomer.FirstName.ToString();    //Loading the first name, last name and email address of the selected customer into the respective text boxes
            this.tbxLastName.Text = this.currCustomer.LastName.ToString();
            this.tbxEmailAddress.Text = this.currCustomer.EmailAddress.ToString();
            this.btnCreateCustomer.Text = "Edit"; 
            this.customerChange = true; //Boolean variable for switching between the modes adding and editing
        }

        /// <summary>
        /// Public constructor for creating a new customer 
        /// </summary>
        /// <param name="customerChange"></param>
        public FrmAddEditCust()     //Constructor for adding customer
        {
            InitializeComponent();
            this.customerChange = false;
        }
        #endregion

        #region Member attributes
        /// <summary>
        /// Customer (containing: First and last name, Email address, balance, date of last change) 
        /// </summary>
        public Customer ACustomer
        {
            get
            {
                return this.aCustomer;       //returns created variable
            }
        }
        #endregion

        #region Private memmber methods
        /// <summary>
        /// Button for adding or editing a customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.customerChange)    //editing customer
                {
                    this.currCustomer.ChangeLastName(this.tbxLastName.Text);

                    if (this.currCustomer.EmailAddress != this.tbxEmailAddress.Text)        //Only if the E-Mail address in the textbox is changed the function "ChangeEmailAddress" is performed
                    {                                                                       //Otherwise E-Mail would be changed every time and an error will occur that the address already exists (an E-Mail address needs to be unique) 
                        this.currCustomer.ChangeEmailAddress(this.tbxEmailAddress.Text);
                    }

                }
                else        //adding customer
                {
                    aCustomer = new Customer(this.tbxFirstName.Text, this.tbxLastName.Text, this.tbxEmailAddress.Text);
                }
                this.DialogResult = DialogResult.OK;        
                this.Close();   //Closing subwindow
            }

            //Catching exceptions if an invalid value is inserted into the textboxes 
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
    }
}
