using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLib;
using UnitTestsProjectLib;
using System.IO;

namespace UnitTestsProjectLib
{
    /// <summary>
    /// This is a test programm for automated software testing of the classes of the project library
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UNIT TESTS OF PROJECT LIBRARY:\n\n");

            #region Tests Encrypt class
            Console.WriteLine("ENCRYPT CLASS:\n");

            UnitTestEncrypt.PositiveEncryptTest();

            UnitTestEncrypt.NegativeEncryptTest();
            #endregion

            #region Tests Customer class
            Console.WriteLine("\n\n\nCUSTOMER CLASS:");

            UnitTestCustomer.FileMissingTest();

            UnitTestCustomer.CreateDataTest();

            UnitTestCustomer.MemberMethodsTest();

            UnitTestCustomer.StaticMethodsTest();
            #endregion

            Console.ReadLine();
        }
    }
}
