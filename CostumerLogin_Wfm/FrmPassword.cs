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
    public partial class FrmPassword : Form
    {
        private string password = "12345";

        public FrmPassword()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.tbxPassword.Text == password)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                

               

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
