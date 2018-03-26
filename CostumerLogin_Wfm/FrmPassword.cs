using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostumerLogin_Wfm
{

    public partial class FrmPassword : Form     //Password window for getting acces to the main programm and the containing data
    {
        #region static variables
        private string password = "12345";
        #endregion

        #region Constructor
        public FrmPassword()
        {
            InitializeComponent();
        }
        #endregion

        #region Private member methods
        /// <summary>
        /// Button for logging in, into the main window and working with the containing data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)     //
        {
            if (this.tbxPassword.Text == password)      //if the password is correct the window "FrmPassword" is getting closed and the main window "FrmTop" is opened
            {
                this.DialogResult = DialogResult.OK;
                FrmTop dialog = new FrmTop();           
                this.Visible = false;
                dialog.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button "btnCancel" closes the whole programm and no access into the main window is provided
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) //
        {
            this.Close();
        }
        #endregion 
    }
}
