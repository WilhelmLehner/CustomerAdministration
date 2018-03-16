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
        private Customer currentCustomer;

        #region Cunstructor
        public FrmAddEditCust(Customer currentCustomer)
        {
            InitializeComponent();
            this.tbxFirstName.Text = this.currentCustomer.FirstName.ToString();
            this.tbxLastName.Text = this.currentCustomer.LastName.ToString();
            this.tbxEmailAddress.Text = this.currentCustomer.EmailAddress.ToString();
        }

        public FrmAddEditCust()
        {
            InitializeComponent();
         
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
                
                
                aCustomer = new Customer(this.tbxFirstName.Text, this.tbxLastName.Text, this.tbxEmailAddress.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
