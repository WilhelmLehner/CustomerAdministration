using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLib;

namespace UnitTestsProjectLib
{
    /// <summary>
    /// Unit tests for Encrypt class
    /// </summary>
    public class UnitTestEncrypt
    {
        private static string validPassPhraseCryp = "!!THE NORTH REMEMBERS!!";
        private static string invalidPassPhraseCryp = "1234";
        private static string testString = "The Lannisters send their regards";

        /// <summary>
        /// Unit test encrypting: valid data
        /// </summary>
        public static void PositiveEncryptTest()
        {
            Console.Write("TEST: Positive test of Encrypt. \nRESULT: ");
            try
            {
                string encrpted = Encrypt.EncryptString(testString, validPassPhraseCryp);
                string decrypted = Encrypt.DecryptString(encrpted, validPassPhraseCryp);
                if (String.Compare(testString, decrypted) == 0) Console.WriteLine("OK");
                else Console.WriteLine("ERROR");
                Console.Write(testString + " --> " + encrpted + "-->" + decrypted + "\n\n");
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                Console.WriteLine("ERRO, Exception was thrown");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
        }

        /// <summary>
        /// Unit test encrypting: invalid data
        /// </summary>
        public static void NegativeEncryptTest()
        {
            string encrpted = Encrypt.EncryptString(testString, validPassPhraseCryp);

            Console.Write("TEST: Nagtive test of Encrypt with wrong pass phrase. \nRESULT: ");

            try
            {
                string decrypted = Encrypt.DecryptString(encrpted, invalidPassPhraseCryp);
                if (String.Compare(testString, decrypted) != 0) Console.WriteLine("OK");
                else Console.WriteLine("ERROR");
                Console.Write(testString + " --> " + encrpted + "-->" + decrypted + "\n\n");
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                Console.WriteLine("OK, Exception was thrown");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
        }
    }
}