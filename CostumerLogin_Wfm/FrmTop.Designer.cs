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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
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
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.gbxSearch.SuspendLayout();
            this.gbxBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFrmTop)).BeginInit();
            this.gbxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxSearch.Controls.Add(this.tbxEntry);
            this.gbxSearch.Enabled = false;
            this.gbxSearch.Location = new System.Drawing.Point(715, 84);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSearch.Size = new System.Drawing.Size(158, 46);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // tbxEntry
            // 
            this.tbxEntry.Location = new System.Drawing.Point(4, 17);
            this.tbxEntry.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEntry.Name = "tbxEntry";
            this.tbxEntry.Size = new System.Drawing.Size(145, 20);
            this.tbxEntry.TabIndex = 0;
            this.tbxEntry.TextChanged += new System.EventHandler(this.tbxEntry_TextChanged);
            // 
            // gbxBalance
            // 
            this.gbxBalance.BackColor = System.Drawing.SystemColors.Control;
            this.gbxBalance.Controls.Add(this.lblBalanceValue);
            this.gbxBalance.Controls.Add(this.btnMoneyPayIn);
            this.gbxBalance.Controls.Add(this.btnMoneyPayOut);
            this.gbxBalance.Controls.Add(this.nudValue);
            this.gbxBalance.Enabled = false;
            this.gbxBalance.Location = new System.Drawing.Point(715, 134);
            this.gbxBalance.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBalance.Name = "gbxBalance";
            this.gbxBalance.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBalance.Size = new System.Drawing.Size(158, 72);
            this.gbxBalance.TabIndex = 1;
            this.gbxBalance.TabStop = false;
            this.gbxBalance.Text = "Balance";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(4, 19);
            this.lblBalanceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(61, 13);
            this.lblBalanceValue.TabIndex = 9;
            this.lblBalanceValue.Text = "Amount [€]:";
            // 
            // btnMoneyPayIn
            // 
            this.btnMoneyPayIn.Location = new System.Drawing.Point(4, 40);
            this.btnMoneyPayIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoneyPayIn.Name = "btnMoneyPayIn";
            this.btnMoneyPayIn.Size = new System.Drawing.Size(70, 28);
            this.btnMoneyPayIn.TabIndex = 3;
            this.btnMoneyPayIn.Text = "Money paid";
            this.btnMoneyPayIn.UseVisualStyleBackColor = true;
            this.btnMoneyPayIn.Click += new System.EventHandler(this.btnMoneyPayIn_Click);
            // 
            // btnMoneyPayOut
            // 
            this.btnMoneyPayOut.Location = new System.Drawing.Point(81, 40);
            this.btnMoneyPayOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoneyPayOut.Name = "btnMoneyPayOut";
            this.btnMoneyPayOut.Size = new System.Drawing.Size(76, 28);
            this.btnMoneyPayOut.TabIndex = 2;
            this.btnMoneyPayOut.Text = "Money owed";
            this.btnMoneyPayOut.UseVisualStyleBackColor = true;
            this.btnMoneyPayOut.Click += new System.EventHandler(this.btnMoneyPayOut_Click);
            // 
            // nudValue
            // 
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudValue.Location = new System.Drawing.Point(69, 16);
            this.nudValue.Margin = new System.Windows.Forms.Padding(2);
            this.nudValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(85, 20);
            this.nudValue.TabIndex = 0;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgvListCustomer.Location = new System.Drawing.Point(9, 11);
            this.dgvListCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListCustomer.MultiSelect = false;
            this.dgvListCustomer.Name = "dgvListCustomer";
            this.dgvListCustomer.ReadOnly = true;
            this.dgvListCustomer.RowHeadersVisible = false;
            this.dgvListCustomer.RowTemplate.Height = 24;
            this.dgvListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCustomer.Size = new System.Drawing.Size(700, 195);
            this.dgvListCustomer.TabIndex = 2;
            this.dgvListCustomer.SelectionChanged += new System.EventHandler(this.dgvListCustomer_SelectionChanged);
            this.dgvListCustomer.DoubleClick += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // CustomerNumber
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CustomerNumber.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle4;
            this.Balance.HeaderText = "Balance [€]";
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
            this.btnAddCustomer.Location = new System.Drawing.Point(4, 17);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(145, 19);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(4, 40);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(145, 19);
            this.btnEditCustomer.TabIndex = 5;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.btnAddCustomer);
            this.gbxCustomer.Controls.Add(this.btnEditCustomer);
            this.gbxCustomer.Location = new System.Drawing.Point(715, 11);
            this.gbxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCustomer.Size = new System.Drawing.Size(158, 69);
            this.gbxCustomer.TabIndex = 9;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // FrmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 216);
            this.Controls.Add(this.gbxCustomer);
            this.Controls.Add(this.dgvListCustomer);
            this.Controls.Add(this.gbxBalance);
            this.Controls.Add(this.gbxSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 255);
            this.Name = "FrmTop";
            this.Text = "Costumer Data";
            this.SizeChanged += new System.EventHandler(this.FrmTop_SizeChanged);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxBalance.ResumeLayout(false);
            this.gbxBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFrmTop)).EndInit();
            this.gbxCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxBalance;
        private System.Windows.Forms.DataGridView dgvListCustomer;
        private System.Windows.Forms.ErrorProvider epFrmTop;
        private System.Windows.Forms.TextBox tbxEntry;
        private System.Windows.Forms.Button btnMoneyPayIn;
        private System.Windows.Forms.Button btnMoneyPayOut;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLastChange;
    }
}

