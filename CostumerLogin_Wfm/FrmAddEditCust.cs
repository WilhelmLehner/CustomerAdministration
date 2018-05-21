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
using System.IO;

namespace CostumerLogin_Wfm
{
    /// <summary>
    /// Subwindow of the main application. Provides the possibility of adding or editing customers. 
    /// </summary>
    public partial class FrmAddEditCust : Form      
    {
        #region Variables
        private static string pathCSVFile = @"Language.csv";
        private Customer aCustomer;
        private Customer currCustomer;
        private bool isAddMode;
        private bool customerChange;
        private string defLanguage = "English";
        #endregion 

        #region Cunstructor
        /// <summary>
        /// Public constructor to create a customer with the data of the current selected customer in the data grid view of the FrmTop.
        /// </summary>
        /// <param name="currentCustomer"></param>
        public FrmAddEditCust(Customer currentCustomer)     //Cunstroctor for editing customer
        {

            InitializeComponent();
            this.currCustomer = currentCustomer;
            this.tbxFirstName.Enabled = false;  //Enabling the textbox "tbxFirstName" for further changing
            this.tbxFirstName.Text = this.currCustomer.FirstName.ToString();    //Loading the first name, last name and email address of the selected customer into the respective text boxes
            this.tbxLastName.Text = this.currCustomer.LastName.ToString();
            this.tbxEmailAddress.Text = this.currCustomer.EmailAddress.ToString();
            isAddMode = false;
            this.customerChange = true; //Boolean variable for switching between the modes adding and editing
            ReadLanguageFromCSV();
        }

        /// <summary>
        /// Public constructor for creating a new customer 
        /// </summary>
        /// <param name="customerChange"></param>
        public FrmAddEditCust()     //Constructor for adding customer
        {
            InitializeComponent();
            this.customerChange = false;
            ReadLanguageFromCSV();
            isAddMode = true;
        }
        #endregion

        #region Member attributes
        /// <summary>
        /// Customer (containing: First and last name, Email address, balance, date of last change) 
        /// </summary>
        public Customer ACustomer
        {
            get
            {
                return this.aCustomer;       //returns created variable
            }
        }
        #endregion

        #region Private event methods
        /// <summary>
        /// Button for adding or editing a customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.customerChange)    //editing customer
                {
                    this.currCustomer.ChangeLastName(this.tbxLastName.Text);

                    if (this.currCustomer.EmailAddress != this.tbxEmailAddress.Text)        //Only if the E-Mail address in the textbox is changed the function "ChangeEmailAddress" is performed
                    {                                                                       //Otherwise E-Mail would be changed every time and an error will occur that the address already exists (an E-Mail address needs to be unique) 
                        this.currCustomer.ChangeEmailAddress(this.tbxEmailAddress.Text);
                    }

                }
                else        //adding customer
                {
                    aCustomer = new Customer(this.tbxFirstName.Text, this.tbxLastName.Text, this.tbxEmailAddress.Text);
                }
                this.DialogResult = DialogResult.OK;        
                this.Close();   //Closing subwindow
            }

            //Catching exceptions if an invalid value is inserted into the textboxes 
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

        /// <summary>
        /// Recognizes change in the Combo Box, changes the language of the labels and saves the actual language in the CSV-file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLanguage(this.cmbLanguage.SelectedItem.ToString());
            WriteLanguageToCSV(this.cmbLanguage.SelectedItem.ToString());
        }
        #endregion


        /// <summary>
        /// Methods for saving the selected Language of the Add and Edit window
        /// </summary>
        /// <param name="selectedLanguage"></param>
        #region Private member methods
        private void WriteLanguageToCSV(string selectedLanguage)
        {
            StreamWriter writer = new StreamWriter(pathCSVFile);

            writer.Write(selectedLanguage);

            writer.Close();
        }


        /// <summary>
        /// Reads the last used language out of an CSV file or sets a default language when first used
        /// </summary>
        private void ReadLanguageFromCSV()
        {
            try
            {
                string selectedLanguage;
                StreamReader reader = new StreamReader(pathCSVFile);    //Reads out the last used language and changes the labels to this language. 
                selectedLanguage = reader.ReadLine();
                ChangeLanguage(selectedLanguage.ToString());

                reader.Close();
            }
            catch (FileNotFoundException)            //If program is first used and no CSV file has been generated before 
            {                                       //Try-Catch catches the FileNotFoundException and a new CSV file is generated. 
                WriteLanguageToCSV(defLanguage);    //The default language is set to "English" 
            }

        }


        /// <summary>
        /// Changes the language in the different labels 
        /// </summary>
        /// <param name="selectedLanguage"></param>
        private void ChangeLanguage(string selectedLanguage)
        {

            if (selectedLanguage == "German")
            {
                this.lblFirstName.Text = "Vorname:";
                this.lblLastName.Text = "Nachname:";
                this.lblLanguage.Text = "Sprache:";

                if (isAddMode) this.btnCreateCustomer.Text = "Erzeugen";
                else this.btnCreateCustomer.Text = "Ändern";
            }
            else if (selectedLanguage == "English")
            {
                this.lblFirstName.Text = "First name:";
                this.lblLastName.Text = "Last name:";
                this.lblLanguage.Text = "Language:";

                if (isAddMode) this.btnCreateCustomer.Text = "Create";
                else this.btnCreateCustomer.Text = "Edit";        
            }
            else if (selectedLanguage == "Spanish")
            {
                this.lblFirstName.Text = "Nombre:";
                this.lblLastName.Text = "Apellido:";
                this.lblLanguage.Text = "Idioma:";

                if (isAddMode) this.btnCreateCustomer.Text = "Crear";
                else this.btnCreateCustomer.Text = "Modificacion";
            }
            else if (selectedLanguage == "Norwegian")
            {
                this.lblFirstName.Text = "Fornavn:";
                this.lblLastName.Text = "Etternavn:";
                this.lblLanguage.Text = "Språk:";

                if (isAddMode) this.btnCreateCustomer.Text = "Skape";
                else this.btnCreateCustomer.Text = "Endre";
            }
        }
        #endregion
    }
}
