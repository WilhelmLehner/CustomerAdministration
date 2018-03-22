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
        //private 
        private string editLastName;
        private string editEMail;
        #endregion


        public FrmTop()
        {
            //FrmPassword dialog = new FrmPassword();
            //dialog.ShowDialog();
            InitializeComponent();
            
           this.listCustomer = Customer.LoadListOfAllCustomers();
            UpdateDataList();
           
        }
       


        //------------BUTTON ADD CUSTOMER-----------------------------------------------------//
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

        //-----------------BUTTON EDIT CUSTOMER-----------------------------------------------//
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
         
            Customer currentSelectedCustomer = 
                Customer.GetCustomerWithNumber
                (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString()));
            

            FrmAddEditCust dialog = new FrmAddEditCust(currentSelectedCustomer);
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                editCustomer = dialog.ACustomer;
                
                listCustomer = Customer.LoadListOfAllCustomers();
                UpdateDataList();
            } 
        }


       
        //----------------BUTTON MONEY PAY IN ----------------------------------//
        private void btnMoneyPayIn_Click(object sender, EventArgs e)
        {
            Customer currentSelectedCustomer =
              Customer.GetCustomerWithNumber
              (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString()));

            currentSelectedCustomer.AddMoneyPaid(Convert.ToDouble(this.nudValue.Value));

            listCustomer = Customer.LoadListOfAllCustomers();
            UpdateDataList();
        }


        //----------------BUTTON MONEY PAY OUT----------------------------------//
        private void btnMoneyPayOut_Click(object sender, EventArgs e)
        {
            Customer currentSelectedCustomer =
              Customer.GetCustomerWithNumber
              (Int32.Parse(this.dgvListCustomer.SelectedRows[0].Cells[0].Value.ToString()));

            currentSelectedCustomer.AddMoneyOwed(Convert.ToDouble(this.nudValue.Value));

            listCustomer = Customer.LoadListOfAllCustomers();
            UpdateDataList();
            dgvListCustomer.Show(); 
        }


        #region Methods 
        private void UpdateDataList()
        {
            dgvListCustomer.Rows.Clear();
            foreach (Customer element in this.listCustomer)
            {
                dgvListCustomer.Rows.Add(element.CustomerNumber, element.FirstName, element.LastName, element.EmailAddress, element.Balance, element.DateLastChange);
            }

        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void tbxEntry_TextChanged(object sender, EventArgs e)
        {
            listCustomer = Customer.ReturnListOfCustomerWhichIncludeStringInNames(tbxEntry.Text);
            this.UpdateDataList();
        }
    }
}
