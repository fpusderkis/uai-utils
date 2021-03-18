using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace uai.utils
{
    public class Hash
    {
        public static string GenerateMD5(object target)
        {
            if (target != null) return ComputeHash(target.ToString(), new MD5CryptoServiceProvider());

            return null;
        }


        public static string GenerateSHA256(object target)
        {
            if (target != null) return ComputeHash(target.ToString(), new SHA256CryptoServiceProvider());

            return null;
        }

        private static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
