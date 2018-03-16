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

    public partial class FrmTop : Form
    {
        #region Member variables
        private Customer aCustomer;
        private List<Customer> listCustomer = new List<Customer>();
        private Customer editCustomer;
        private string editLastName;
        private string editEMail;
        #endregion


        public FrmTop()
        {
            InitializeComponent();

          
           this.listCustomer = Customer.LoadListOfAllCustomers();
            UpdateDataList();
           

            
        }
        private void UpdateDataList()
        {
            dgvListCustomer.Rows.Clear();
            foreach (Customer element in this.listCustomer)
            {
                dgvListCustomer.Rows.Add(element.CustomerNumber, element.FirstName, element.LastName, element.EmailAddress, element.Balance, element.DateLastChange);
            }

        }


        //------------BUTTON ADD CUSTOMER-------------------------------------//
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddEditCust dialog = new FrmAddEditCust();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.aCustomer = dialog.ACustomer;
                
            }
            this.listCustomer.Add(aCustomer);
            this.dgvListCustomer.Refresh();
            UpdateDataList();

        }

        //-----------------BUTTON EDIT CUSTOMER
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer currentSelectedCustomer = 
                Customer.GetCustomerWithNumber
                (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString()));

            FrmAddEditCust dialog = new FrmAddEditCust(currentSelectedCustomer);




            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.aCustomer = dialog.ACustomer;
            }
        }

        
    }
}
