using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLib;
using System.IO;

namespace UnitTestsProjectLib
{
    /// <summary>
    /// Unit tests for Customer class
    /// These tests are just for a rough unit test. The detailed tests were done at the system tests.
    /// </summary>
    public class UnitTestCustomer
    {
        #region Membervariables
        public static string pathTestDataFile = @"ListCustomer.csv"; //path must be changed at the customer class for tests
        #endregion

        #region Test cases
        private static string[] positiveTestsFirstname = new string[] { "Josef", "AJ" };
        private static string[] positiveTestsLastname = new string[] { "Anzengruber", "Li" };
        private static string[] negativeTestsFirstname = new string[] { "J", "Jo4", "Jose%f" };
        private static string[] negativeTestsLastname = new string[] { "A", "Li6", "Anzen$gruber" };
        private static string[] negativeTestsEmail = new string[] { "josef.@gmail.com", "josef@.gmail.com", "@gmail.com", "josef@gmail.c", "josef.@gmail.5co", null, "Josef.Anzengruber@gmail.com" };
        #endregion

        #region Constructor Tests
        /// <summary>
        /// Test of Constructor: Valid test cases
        /// </summary>
        public static void PositiveConstructorTests()
        {
            Customer newCustomer;
            string firstname;
            string lastname;
            string email;

            Console.Write("\n\nTEST: Positive constructor test of Customer. \n");
            for (int i = 0; i < positiveTestsFirstname.Length; i++)
            {
                for (int j = 0; j < positiveTestsLastname.Length; j++)
                {
                    firstname = positiveTestsFirstname[i];
                    lastname = positiveTestsLastname[j];
                    email = string.Format("{0}.{1}@gmail.com", firstname, lastname);
                    try
                    {
                        newCustomer = new Customer(firstname, lastname, email);
                        Console.WriteLine("OK: " + newCustomer.ToString());
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine("ERROR: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("ERROR: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("ERROR: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                    }
                }
            }
        }

        /// <summary>
        /// Test of Constructor: Invalid names (first and last)
        /// </summary>
        public static void NegativeConstructorTestsNames()
        {
            Customer newCustomer;
            string firstname;
            string lastname;
            string email;

            Console.WriteLine("\n\nTEST: Negative constructor test for names.");
            for (int i = 0; i < negativeTestsFirstname.Length; i++)
            {
                firstname = negativeTestsFirstname[i];
                lastname = positiveTestsLastname[0];
                email = string.Format("{0}.{1}@gmail.com", firstname, lastname);
                try
                {
                    newCustomer = new Customer(firstname, lastname, email);
                    Console.WriteLine("ERROR: Invalid customer was created: " + newCustomer.ToString());
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("OK: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: unhandled exception; Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                } 
            }

            for (int i = 0; i < negativeTestsLastname.Length; i++)
            {
                firstname = positiveTestsFirstname[0];
                lastname = negativeTestsLastname[i];
                email = string.Format("{0}.{1}@gmail.com", firstname, lastname);
                try
                {
                    newCustomer = new Customer(firstname, lastname, email);
                    Console.WriteLine("ERROR: Invalid customer was created: " + newCustomer.ToString());
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("OK: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: unhandled exception; Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                }
            }
        }

        /// <summary>
        /// Test of Constructor: Invalid mail adresses
        /// </summary>
        public static void NegativeConstructorTestsEmail()
        {
            Customer newCustomer;
            string firstname;
            string lastname;
            string email;

            Console.WriteLine("\n\nTEST: Negative constructor test for Email.");
            for (int i = 0; i < negativeTestsEmail.Length; i++)
            {
                firstname = positiveTestsFirstname[0];
                lastname = positiveTestsLastname[0];
                email = negativeTestsEmail[i];
                try
                {
                    newCustomer = new Customer(firstname, lastname, email);
                    Console.WriteLine("ERROR: Invalid customer was created: " + newCustomer.ToString());
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("OK: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("OK: Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: unhandled exception; Firstname: {0}, Lastname: {1}, Email: {2}; Exception: " + ex.Message, firstname, lastname, email);
                }
            }
        }
        #endregion

        #region public Methods
        /// <summary>
        /// Test for missing file
        /// </summary>
        public static void FileMissingTest()
        {
            Console.Write("\n\nTEST: File is missing. \nRESULT: ");
            File.Delete(pathTestDataFile);
            try
            {
                Customer.LoadListOfAllCustomers();
                Console.WriteLine("ERROR; No exception was thrown");
            }
            catch (IOException ex)
            {
                Console.WriteLine("OK; Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Tests to create Data
        /// </summary>
        public static void CreateDataTest()
        {
            Customer.CreateNewLogFile();

            PositiveConstructorTests();

            NegativeConstructorTestsNames();

            NegativeConstructorTestsEmail();
        }

        /// <summary>
        /// Test for several member methods for manipulating the customer data
        /// </summary>
        public static void MemberMethodsTest()
        {
            Console.WriteLine("\n\nTEST: Test of several member methods: check yourself (1. add money, 2. withdraw money, 3. change Email, 4. change last name)\n\nPrevious:");
            List<Customer> list = Customer.LoadListOfAllCustomers();
            PrintList(list);
            if (list.Count >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            list.ToArray()[i].AddMoneyPaid(100.0);
                            break;
                        case 1:
                            list.ToArray()[i].AddMoneyOwed(200.0);
                            break;
                        case 2:
                            list.ToArray()[i].ChangeEmailAddress("newMailAdress@doSchauHer.at");
                            break;
                        default:
                            list.ToArray()[i].ChangeLastName("Superman");
                            break;
                    }
                }

                Console.WriteLine("\nAfterwards:");
                list = Customer.LoadListOfAllCustomers();
                PrintList(list);
            }
            else
            {
                Console.WriteLine("ERROR: Too less examples in list");
            }
        }

        public static void StaticMethodsTest()
        {
            Console.WriteLine("\n\nTEST: Test of static methods which are not tested in other cases before: check yourself\n");

            Console.WriteLine("Look for customers with customer number 100001: RESULT: {0}\n", Customer.GetCustomerWithNumber(100001).ToString());

            Console.WriteLine("Look for customers who include an \"A\" in their names:");

            List<Customer> list = Customer.ReturnListOfCustomerWhichIncludeStringInNames("A");

            PrintList(list);

        }
        #endregion

        #region private Methods
        private static void PrintList(List<Customer> list)
        {
            foreach (Customer element in list)
            {
                Console.WriteLine(element);
            }
        }
        #endregion
    }
}