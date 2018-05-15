using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectLib
{
    /// <summary>
    /// This class represents all important attributes of a customer
    /// </summary>
    public class Customer
    {
        #region Constants
        private const string PATHcSVfILE = @"ListCustomer.csv";
        private const bool CRYPdATA = true;
        private const string PASSpHRASEcRYP = "!!THE NORTH REMEMBERS!!";
        #endregion

        #region Member variables
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int customerNumber;
        private double balance;
        private DateTime dateLastChange;
        #endregion

        #region Constructor
        /// <summary>
        /// Public constructor for adding a customer
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        public Customer(string firstName, string lastName, string emailAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.customerNumber = GetUniqueCustomerNumber();
            this.balance = 0.0;
            this.dateLastChange = DateTime.Now;
            this.UpdateCSV(); //the new Customer is immidiatelly saved in the CSV file
        }

        /// <summary>
        /// Private constructor to create a customer with all attributes
        /// </summary>
        /// <param name="customerNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="balance"></param>
        /// <param name="dateLastChange"></param>
        private Customer(int customerNumber, string firstName, string lastName, string emailAddress, double balance, DateTime dateLastChange)
        {
            //the new Customer is NOT saved in the CSV file; this Constructor is just for internal use
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.customerNumber = customerNumber;
            this.balance = balance;
            this.dateLastChange = dateLastChange;
        }
        #endregion

        #region Member attributes
        /// <summary>
        /// First name of customer
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (IsNameValid(value)) //is check is no requirment but it is done to ensure realistic inputs
                {
                    this.firstName = value;
                }
                else throw new ArgumentOutOfRangeException(value, "For the first name only letters are allowed and it must include at least 2 letters");
            }
        }

        /// <summary>
        /// Last name of customer
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (IsNameValid(value))//is check is no requirment but it is done to ensure realistic inputs
                {
                    this.lastName = value;
                }
                else throw new ArgumentOutOfRangeException(value, "For the last name only letters are allowed and it must include at least 2 letters");
            }
        }

        /// <summary>
        /// Email adress of customer
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            private set
            {
                if (IsEmailAddressValid(value))
                {
                    if (IsEmailAddressUnique(value))
                    {
                        this.emailAddress = value;
                    }
                    else throw new ArgumentException("The entered email address is already taken!");
                }
                else throw new ArgumentOutOfRangeException(value, "The entered email address is not valid!");
            }
        }

        /// <summary>
        /// Customer number of customer
        /// </summary>
        public int CustomerNumber
        {
            get
            {
                return this.customerNumber;
            }
        }

        /// <summary>
        /// Balance of customer
        /// </summary>
        public double Balance
        {
            get
            {
                return this.balance;
            }
        }

        /// <summary>
        /// Date of last change of the balance of customer
        /// </summary>
        public DateTime DateLastChange
        {
            get
            {
                return this.dateLastChange;
            }
        }
        #endregion

        #region public member methods
        /// <summary>
        /// Returns string with all informations about Customer
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, balance [EUR]: {3:0.00}, last change on: {4}", this.LastName, this.FirstName, this.EmailAddress, this.Balance, this.DateLastChange.ToShortDateString());
        }

        /// <summary>
        /// This functions adds the amount of money to the balance of the account
        /// </summary>
        /// <param name="amount"></param>
        public void AddMoneyPaid(double amount)
        {
            this.balance += amount;
            this.dateLastChange = DateTime.Now;
            this.UpdateCSV();
        }

        /// <summary>
        /// This function takes the amount of money from the account balance
        /// </summary>
        /// <param name="amount"></param>
        public void AddMoneyOwed(double amount)
        {
            this.balance -= amount;
            this.dateLastChange = DateTime.Now;
            this.UpdateCSV();
        }

        /// <summary>
        /// The last name of the customer is changed to the newLastName
        /// </summary>
        /// <param name="newLastName"></param>
        public void ChangeLastName(string newLastName)
        {
            this.LastName = newLastName;
            this.UpdateCSV();
        }

        /// <summary>
        /// The email address is changed to the newEmailAddress
        /// </summary>
        /// <param name="newEmailAddress"></param>
        public void ChangeEmailAddress(string newEmailAddress)
        {
            if (newEmailAddress == this.EmailAddress)
            {
                throw new InvalidOperationException("The customer has already this email adress!!");
            }
            else
            {
                this.EmailAddress = newEmailAddress;
                this.UpdateCSV();
            }
        }
        #endregion

        #region private member methods
        /// <summary>
        /// The saving file is updated with object: either the attributes of the object are updated or if the object doesn't exist, it is added to the list
        /// </summary>
        private void UpdateCSV()
        {
            List<Customer> listCustomer = LoadListOfAllCustomers();
            bool customerChanged = false;
            int i = 0;

            while (!customerChanged)
            {
                if (listCustomer.Count > 0 && listCustomer[i].customerNumber == this.customerNumber)
                {
                    listCustomer[i].FirstName = this.FirstName;
                    listCustomer[i].LastName = this.LastName;
                    listCustomer[i].emailAddress = this.EmailAddress;
                    listCustomer[i].balance = this.Balance;
                    listCustomer[i].dateLastChange = this.DateLastChange;
                    customerChanged = true;
                }

                i++;

                if (i >= listCustomer.Count && !customerChanged)
                {
                    listCustomer.Add(this);
                    customerChanged = true;
                }
            }
            WriteListeOfAllCustomersToCSV(listCustomer);
        }
        #endregion

        #region public static member methods
        /// <summary>
        /// Returns a list of all saved Customers
        /// </summary>
        /// <returns></returns>
        public static List<Customer> LoadListOfAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            string[] lineParts;
            string line;

            StreamReader reader = new StreamReader(PATHcSVfILE, Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    lineParts = line.Split(';');
                    if (CRYPdATA)
                    {
                        listCustomer.Add(new Customer(Int32.Parse(Encrypt.DecryptString(lineParts[0], PASSpHRASEcRYP)), Encrypt.DecryptString(lineParts[1], PASSpHRASEcRYP), Encrypt.DecryptString(lineParts[2], PASSpHRASEcRYP), Encrypt.DecryptString(lineParts[3], PASSpHRASEcRYP), Double.Parse(Encrypt.DecryptString(lineParts[4], PASSpHRASEcRYP)), DateTime.Parse(Encrypt.DecryptString(lineParts[5], PASSpHRASEcRYP))));
                    }
                    else
                    {
                        listCustomer.Add(new Customer(Int32.Parse(lineParts[0]), lineParts[1], lineParts[2], lineParts[3], Double.Parse(lineParts[4]), DateTime.Parse(lineParts[5])));
                    }
                }
            }
            reader.Close();
            return listCustomer;
        }

        /// <summary>
        /// Returns the Customer with the customer number
        /// </summary>
        /// <param name="custNumber"></param>
        /// <returns></returns>
        public static Customer GetCustomerWithNumber(int custNumber)
        {
            List<Customer> listCustomer = LoadListOfAllCustomers();
            Customer customer = null;

            foreach (Customer element in listCustomer)
            {
                if (element.CustomerNumber == custNumber)
                {
                    customer = element;
                }
            }
            return customer;
        }

        /// <summary>
        /// Checks if the email adress is valid
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        public static bool IsEmailAddressValid(string emailAddress)
        {
            string allowedSymbols = "!#$%&'*+-/=?^_`{|}~.@";
            bool isValid = false;
            bool areOnlyLetters = false;

            if (emailAddress != null)
            {
                string[] addressparts = emailAddress.Split('@');
                if (addressparts.Length == 2)
                {
                    string[] partsAfter = addressparts[1].Split('.');
                    if (partsAfter.Length >= 2)
                    {
                        string afterFinalDot = partsAfter[partsAfter.Length - 1];
                        if (afterFinalDot.Length > 1 && afterFinalDot.Length < 5)
                        {
                            for (int i = 0; i < afterFinalDot.Length; i++)
                            {
                                if (!Char.IsLetter(afterFinalDot[i]))
                                {
                                    break;
                                }
                                else
                                {
                                    if (i == afterFinalDot.Length - 1) areOnlyLetters = true;
                                }
                            }

                            if (areOnlyLetters && addressparts[0].Length > 0)
                            {
                                if (addressparts[0][0] != '.' && addressparts[0][addressparts[0].Length - 1] != '.' && addressparts[1][0] != '.')
                                {
                                    for (int i = 0; i < emailAddress.Length; i++)
                                    {
                                        if (!Char.IsLetterOrDigit(emailAddress[i]))
                                        {
                                            if (allowedSymbols.IndexOf(emailAddress[i]) == -1)
                                            {
                                                break;
                                            }
                                        }

                                        if (i == emailAddress.Length - 1)
                                        {
                                            isValid = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return isValid;
        }

        /// <summary>
        /// Checks if name (first name and last name) is valid 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsNameValid(string name)
        {
            bool isValid = true;

            if (!String.IsNullOrWhiteSpace(name) && name.Length > 1)
            {
                int i = 0;

                while (i < name.Length && isValid)
                {
                    if (!Char.IsLetter(name[i]))
                    {
                        isValid = false;
                    }
                    i++;
                }
            }
            else isValid = false;

            return isValid;
        }

        /// <summary>
        /// Returns list of customer which include the given string either in the first or in the last name.
        /// </summary>
        /// <param name="includedString"></param>
        /// <returns></returns>
        public static List<Customer> ReturnListOfCustomerWhichIncludeStringInNames(string includedString)
        {
            List<Customer> liste = Customer.LoadListOfAllCustomers();
            List<Customer> output = new List<Customer>();

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].FirstName.Contains(includedString) || liste[i].LastName.Contains(includedString))
                {
                    output.Add(liste[i]);
                }
            }

            return output; ;
        }

        /// <summary>
        /// Creats a new LogFile and overwrites the old one
        /// </summary>
        public static void CreateNewLogFile()
        {
            FileStream stream = File.Create(PATHcSVfILE);
            stream.Close();
        }
        #endregion

        #region private static member methods
        /// <summary>
        /// Writes list of all customers to CSV file
        /// </summary>
        /// <param name="listAllCustomers"></param>
        private static void WriteListeOfAllCustomersToCSV(List<Customer> listAllCustomers)
        {
            StreamWriter writer = new StreamWriter(PATHcSVfILE);
            string line;
            foreach (Customer element in listAllCustomers)
            {
                if (CRYPdATA)
                {
                    line = string.Format("{0};{1};{2};{3};{4};{5}", Encrypt.EncryptString(element.CustomerNumber.ToString(), PASSpHRASEcRYP), Encrypt.EncryptString(element.FirstName, PASSpHRASEcRYP), Encrypt.EncryptString(element.LastName, PASSpHRASEcRYP),
                        Encrypt.EncryptString(element.EmailAddress, PASSpHRASEcRYP), Encrypt.EncryptString(element.Balance.ToString(), PASSpHRASEcRYP), Encrypt.EncryptString(element.DateLastChange.ToShortDateString(), PASSpHRASEcRYP));
                }
                else
                {
                    line = string.Format("{0};{1};{2};{3};{4};{5}", element.CustomerNumber, element.FirstName, element.LastName, element.EmailAddress, element.Balance.ToString(), element.DateLastChange.ToShortDateString());

                }
                writer.WriteLine(line);
            }
            writer.Close();
        }

        /// <summary>
        /// Gets the next customer number. if there is no number it initilizes the the first number with the value 100000
        /// </summary>
        /// <returns></returns>
        private static int GetUniqueCustomerNumber()
        {
            int number;
            List<Customer> listCustomer = LoadListOfAllCustomers();
            if (listCustomer.Count == 0)
            {
                number = 100000;
            }
            else
            {
                number = listCustomer[listCustomer.Count - 1].CustomerNumber + 1;
            }
            return number;
        }

        /// <summary>
        /// Checks if the email adress is unique in the file system
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        private static bool IsEmailAddressUnique(string emailAddress)
        {
            bool isUnique = true;
            List<Customer> listCustomer = LoadListOfAllCustomers();
            foreach (Customer element in listCustomer)
            {
                if (element.EmailAddress == emailAddress)
                {
                    isUnique = false;
                    break;
                }
            }
            return isUnique;
        }
        #endregion
    }
}
