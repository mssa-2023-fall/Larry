using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Aes = System.Runtime.Intrinsics.Arm.Aes;

namespace Module_5_Lab_2_CustomersDB
{
    public class Bools_For_Password_Verification
    {
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
          if (array1.Length != array2.Length)
          {
            return false;
          }

          for (int i = 0; i < array1.Length; i++)
          {
            if (array1[i] != array2[i])
            {
              return false;
            }
          }

          return true;
        }
        public async Task<string> DecryptAsync(byte[] hashConvertedPassAndSalt, string password)
        {
            var salt = "HashThis";
            var fromPassword_Hash = new Password_Hash();

            password = fromPassword_Hash.Password_Hashing(password, salt);

            using Aes aes = Aes.Create();
            aes.Key = DeriveKeyFromPassword(passphrase);
            aes.IV = IV;
            using MemoryStream input = new(encrypted);
            using CryptoStream cryptoStream = new(input, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using MemoryStream output = new();
            await cryptoStream.CopyToAsync(output);

            return Encoding.Unicode.GetString(output.ToArray());

        }
    }
}

