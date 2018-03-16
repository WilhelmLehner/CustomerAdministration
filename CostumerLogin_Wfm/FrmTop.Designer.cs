namespace CostumerLogin_Wfm
{
    partial class FrmTop
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxEntry = new System.Windows.Forms.TextBox();
            this.gbxBalance = new System.Windows.Forms.GroupBox();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.btnMoneyPayIn = new System.Windows.Forms.Button();
            this.btnMoneyPayOut = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.dgvListCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfLastChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epFrmTop = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxSearch.SuspendLayout();
            this.gbxBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFrmTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxSearch.Controls.Add(this.lblSearchCustomer);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.tbxEntry);
            this.gbxSearch.Location = new System.Drawing.Point(12, 83);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(269, 90);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Location = new System.Drawing.Point(6, 23);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(117, 17);
            this.lblSearchCustomer.TabIndex = 8;
            this.lblSearchCustomer.Text = "Search Customer";
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
            // gbxBalance
            // 
            this.gbxBalance.BackColor = System.Drawing.SystemColors.Control;
            this.gbxBalance.Controls.Add(this.lblBalanceValue);
            this.gbxBalance.Controls.Add(this.btnMoneyPayIn);
            this.gbxBalance.Controls.Add(this.btnMoneyPayOut);
            this.gbxBalance.Controls.Add(this.nudValue);
            this.gbxBalance.Location = new System.Drawing.Point(287, 83);
            this.gbxBalance.Name = "gbxBalance";
            this.gbxBalance.Size = new System.Drawing.Size(253, 90);
            this.gbxBalance.TabIndex = 1;
            this.gbxBalance.TabStop = false;
            this.gbxBalance.Text = "Balance";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(6, 24);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(99, 17);
            this.lblBalanceValue.TabIndex = 9;
            this.lblBalanceValue.Text = "Balance Value";
            // 
            // btnMoneyPayIn
            // 
            this.btnMoneyPayIn.Location = new System.Drawing.Point(91, 49);
            this.btnMoneyPayIn.Name = "btnMoneyPayIn";
            this.btnMoneyPayIn.Size = new System.Drawing.Size(75, 35);
            this.btnMoneyPayIn.TabIndex = 3;
            this.btnMoneyPayIn.Text = "Pay-In";
            this.btnMoneyPayIn.UseVisualStyleBackColor = true;
            //this.btnMoneyPayIn.Click += new System.EventHandler(this.btnMoneyPayIn_Click);
            // 
            // btnMoneyPayOut
            // 
            this.btnMoneyPayOut.Location = new System.Drawing.Point(172, 49);
            this.btnMoneyPayOut.Name = "btnMoneyPayOut";
            this.btnMoneyPayOut.Size = new System.Drawing.Size(75, 35);
            this.btnMoneyPayOut.TabIndex = 2;
            this.btnMoneyPayOut.Text = "Pay-Out";
            this.btnMoneyPayOut.UseVisualStyleBackColor = true;
           // this.btnMoneyPayOut.Click += new System.EventHandler(this.btnMoneyPayOut_Click);
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(127, 21);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 22);
            this.nudValue.TabIndex = 0;
            // 
            // dgvListCustomer
            // 
            this.dgvListCustomer.AllowUserToAddRows = false;
            this.dgvListCustomer.AllowUserToDeleteRows = false;
            this.dgvListCustomer.AllowUserToOrderColumns = true;
            this.dgvListCustomer.AllowUserToResizeRows = false;
            this.dgvListCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNumber,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Balance,
            this.DateOfLastChange});
            this.dgvListCustomer.Location = new System.Drawing.Point(21, 215);
            this.dgvListCustomer.Name = "dgvListCustomer";
            this.dgvListCustomer.RowHeadersVisible = false;
            this.dgvListCustomer.RowTemplate.Height = 24;
            this.dgvListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCustomer.Size = new System.Drawing.Size(936, 150);
            this.dgvListCustomer.TabIndex = 2;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.HeaderText = "Customer number";
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // DateOfLastChange
            // 
            this.DateOfLastChange.HeaderText = "Date of last change";
            this.DateOfLastChange.Name = "DateOfLastChange";
            this.DateOfLastChange.ReadOnly = true;
            // 
            // epFrmTop
            // 
            this.epFrmTop.ContainerControl = this;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(115, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(115, 36);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomer.TabIndex = 5;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Location = new System.Drawing.Point(12, 9);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(101, 17);
            this.lblAddCustomer.TabIndex = 6;
            this.lblAddCustomer.Text = "Add Customer:";
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Location = new System.Drawing.Point(12, 39);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(100, 17);
            this.lblEditCustomer.TabIndex = 7;
            this.lblEditCustomer.Text = "Edit Customer:";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(9, 195);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(79, 17);
            this.lblCustomers.TabIndex = 8;
            this.lblCustomers.Text = "Customers:";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(ProjectLib.Customer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ProjectLib.Customer);
            // 
            // FrmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 400);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblEditCustomer);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgvListCustomer);
            this.Controls.Add(this.gbxBalance);
            this.Controls.Add(this.gbxSearch);
            this.Name = "FrmTop";
            this.Text = "Costumer Data";
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxBalance.ResumeLayout(false);
            this.gbxBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFrmTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxBalance;
        private System.Windows.Forms.DataGridView dgvListCustomer;
        private System.Windows.Forms.ErrorProvider epFrmTop;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxEntry;
        private System.Windows.Forms.Button btnMoneyPayIn;
        private System.Windows.Forms.Button btnMoneyPayOut;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLastChange;
    }
}

