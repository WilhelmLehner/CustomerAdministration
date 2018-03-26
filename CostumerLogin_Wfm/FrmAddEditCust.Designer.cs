namespace CostumerLogin_Wfm
{
    partial class FrmAddEditCust
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.epCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(102, 10);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFirstName.MaxLength = 150;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(154, 20);
            this.tbxFirstName.TabIndex = 0;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(102, 32);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLastName.MaxLength = 150;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(154, 20);
            this.tbxLastName.TabIndex = 1;
            // 
            // tbxEmailAddress
            // 
            this.tbxEmailAddress.Location = new System.Drawing.Point(102, 55);
            this.tbxEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmailAddress.MaxLength = 150;
            this.tbxEmailAddress.Name = "tbxEmailAddress";
            this.tbxEmailAddress.Size = new System.Drawing.Size(154, 20);
            this.tbxEmailAddress.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 14);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 35);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 58);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Mail:";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(9, 79);
            this.btnCreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(247, 19);
            this.btnCreateCustomer.TabIndex = 6;
            this.btnCreateCustomer.Text = "Create";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // epCustomer
            // 
            this.epCustomer.ContainerControl = this;
            // 
            // FrmAddEditCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 106);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxEmailAddress);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(283, 145);
            this.Name = "FrmAddEditCust";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxEmailAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.ErrorProvider epCustomer;
    }
}