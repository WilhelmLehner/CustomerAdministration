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
    public partial class FrmAddEditCust : Form
    {
        private Customer aCustomer;
        private Customer currCustomer;
        private bool customerChange;

        #region Cunstructor
        public FrmAddEditCust(Customer currentCustomer)
        {
           
            InitializeComponent();
            this.currCustomer = currentCustomer;
            this.tbxFirstName.Enabled = false; 
            this.tbxFirstName.Text = this.currCustomer.FirstName.ToString();
            this.tbxLastName.Text = this.currCustomer.LastName.ToString();
            this.tbxEmailAddress.Text = this.currCustomer.EmailAddress.ToString();
            this.btnCreateCustomer.Text = "Edit";
            this.customerChange = true;
        }

        public FrmAddEditCust()
        {
            InitializeComponent();
            this.customerChange = false;
        }
        #endregion

        //Eigenschaft Konto----------------------------//
        public Customer ACustomer
        {
            get
            {
                return this.aCustomer;       //Rückgabe des Erstellten Kontos
            }
        }



        //Anlegen des Kontos--------------------------------------------//
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
               if (this.customerChange)
                {
                    this.currCustomer.ChangeLastName(this.tbxLastName.Text);

                    if(this.currCustomer.EmailAddress != this.tbxEmailAddress.Text)
                    {
                        this.currCustomer.ChangeEmailAddress(this.tbxEmailAddress.Text);
                    }
                   
                }
               else
                {
                    aCustomer = new Customer(this.tbxFirstName.Text, this.tbxLastName.Text, this.tbxEmailAddress.Text);

                   
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
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
    }
}
