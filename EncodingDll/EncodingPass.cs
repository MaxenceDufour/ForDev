using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncodingDll
{
    /// <summary>
    /// Business class of encryption
    /// </summary>
    public static class EncodingPass
    {
        /// <summary>
        /// Method of hashing and salting
        /// </summary>
        /// <param name="element">the string element to encrypt</param>
        /// <returns>the encrypt element</returns>
        public static byte[] SalAndHash(string element)
        {
            Encoding u8 = Encoding.UTF8;
            byte[] textAsByte = u8.GetBytes($"u0n2p5e7u4D9e@s)a!laGùe$pa,erCi{element}u0n2p5e57dncpo3édzpa,erCi");
            SHA512 sha512 = SHA512Cng.Create();
            byte[] hash = sha512.ComputeHash(textAsByte);
            return hash;
        }
    }
}
