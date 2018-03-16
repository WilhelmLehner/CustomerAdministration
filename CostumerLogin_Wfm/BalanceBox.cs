using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLib; 

namespace CostumerLogin_Wfm
{
    public partial class BalanceBox : GroupBox
    {
        #region Member variables 
        private NumericUpDown nudValue = new NumericUpDown();
        private Button btnMoneyPayIn;
        private Button btnMoneyPayOut;
        private Label lblBalanceValue;
        private Customer aCustomer; 
        #endregion


        #region Constuctor
        public BalanceBox()
            {
         // gbxBalance
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.btnMoneyPayIn);
            this.Controls.Add(this.btnMoneyPayOut);
            this.Controls.Add(this.nudValue);
            this.Location = new System.Drawing.Point(287, 83);
            this.Name = "gbxBalance";
            this.Size = new System.Drawing.Size(253, 90);
            this.TabIndex = 1;
            this.TabStop = false;
            this.Text = "Balance";
            // 
            // btnMoneyPayIn
            // 
            this.btnMoneyPayIn.Location = new System.Drawing.Point(91, 49);
            this.btnMoneyPayIn.Name = "btnMoneyPayIn";
            this.btnMoneyPayIn.Size = new System.Drawing.Size(75, 35);
            this.btnMoneyPayIn.TabIndex = 3;
            this.btnMoneyPayIn.Text = "Pay-In";
            this.btnMoneyPayIn.UseVisualStyleBackColor = true;
            this.btnMoneyPayIn.Click += new System.EventHandler(this.btnMoneyPayIn_Click);
            // 
            // btnMoneyPayOut
            // 
            this.btnMoneyPayOut.Location = new System.Drawing.Point(172, 49);
            this.btnMoneyPayOut.Name = "btnMoneyPayOut";
            this.btnMoneyPayOut.Size = new System.Drawing.Size(75, 35);
            this.btnMoneyPayOut.TabIndex = 2;
            this.btnMoneyPayOut.Text = "Pay-Out";
            this.btnMoneyPayOut.UseVisualStyleBackColor = true;
           
            this.btnMoneyPayOut.Click += new System.EventHandler(this.btnMoneyPayOut_Click);
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(127, 21);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 22);
            this.nudValue.TabIndex = 0;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(6, 24);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(99, 17);
            this.lblBalanceValue.TabIndex = 9;
            this.lblBalanceValue.Text = "Balance Value";
            }
        #endregion

        private void btnMoneyPayIn_Click(object sender, EventArgs e)
        {

            this.aCustomer.AddMoneyPaid(Convert.ToDouble(this.nudValue));
        }

        private void btnMoneyPayOut_Click(object sender, EventArgs e)
        {
            this.aCustomer.AddMoneyOwed(Convert.ToDouble(this.nudValue));
        }

    }
}
