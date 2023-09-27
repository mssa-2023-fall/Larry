using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Module_5_Lab_2_CustomersDB
{
    public class Password_Hash
    {
        public string Password_Hashing(string password, string salt)
        {
            string hash;
            if (password == null || password == "")
            {
                string nada = "Nada";
                return nada;
            }

            // Uses SHA256 to create the hash
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] convertPassAndSalt = System.Text.Encoding.UTF8.GetBytes(password + salt);        //can't hash unless the password/salt are in bytes//converting to bytes
                byte[] hashConvertedPassAndSalt = sha.ComputeHash(convertPassAndSalt);      //byte converted password/salt are hashed via SHA256


                string newHash = BitConverter.ToString(hashConvertedPassAndSalt).Replace("-", String.Empty); //converts $hashConvertedPassAndSalt back to a string.
                hash = newHash;

            }
            return hash;
        }
        public string Password_Decrypt(string hash)
        {
            
        }

    }
}
