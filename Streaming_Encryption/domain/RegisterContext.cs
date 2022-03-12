using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_Encryption.domain
{
    internal static class RegisterContext
    {
        public static string[]? key = null;

        private static string values = "01";
        public static string FilterTextBox(string register)
        {
            for (int i = 0; i < register.Length; i++)
            {
                if (!values.Contains(register[i]))
                {
                    register = register.Replace($"{register[i]}", String.Empty);
                    i--;
                }
            }
            return register;

        }

        public static bool IsEnoughNumbers(string register)
        {
            if (register.Length != 34 || register == null)
                return false;

            return true;
        }

        public static void GenerateKey(string register)
        {
            if (FileContext.bufferBinary == null)
            {
                return;
            }

            key = new string[FileContext.bufferBinary.Length];

            for (int i = 0; i < FileContext.bufferBinary.Length; i++)
            {
                for (int j = 0; j < FileContext.bufferBinary[i].Length; j++)
                {
                    int incryptedByte = Convert.ToInt16(register[0]) ^ Convert.ToInt16(register[19]);
                    incryptedByte ^= Convert.ToInt16(register[20]);
                    incryptedByte ^= Convert.ToInt16(register[33]);

                    key[i] += register[0];

                    register = register.Substring(1);
                    register += incryptedByte;
                }
            }
            KeyContext.key = key;
        }
    }
}
