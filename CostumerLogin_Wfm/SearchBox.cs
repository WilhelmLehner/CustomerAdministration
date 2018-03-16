using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLib;

namespace CostumerLogin_Wfm
{
    public partial class SearchBox : GroupBox
    {
        #region Member variables
        private TextBox tbxEntry;
        private Button btnSearch;
        private Label lblSearchCustomer; 
        #endregion

        #region Constuctor
        public SearchBox()
        {
            tbxEntry = new TextBox();
            btnSearch = new Button();

            // gbxSearch
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxEntry);
            this.Location = new System.Drawing.Point(12, 83);
            this.Name = "gbxSearch";
            this.Size = new System.Drawing.Size(269, 90);
            this.TabIndex = 0;
            this.TabStop = false;
            this.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(188, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;

            // 
            // tbxEntry
            // 
            this.tbxEntry.Location = new System.Drawing.Point(129, 19);
            this.tbxEntry.Name = "tbxEntry";
            this.tbxEntry.Size = new System.Drawing.Size(134, 22);
            this.tbxEntry.TabIndex = 0;

            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Location = new System.Drawing.Point(6, 23);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(117, 17);
            this.lblSearchCustomer.TabIndex = 8;
            this.lblSearchCustomer.Text = "Search Customer";
        }
        #endregion

        private Customer aCustomer; 

        public Customer ACustomer
        {
            get
            {
                return this.aCustomer;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

    }
}
