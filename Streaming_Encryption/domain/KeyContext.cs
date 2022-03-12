using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_Encryption.domain
{
    internal class KeyContext
    {
        public static byte[]? bufferKeyDigit = null;
        public static string[]? bufferKeyBinary = null;
        public static string[]? key = null;
        public static byte[]? keyDigit = null;

        private static string values = "01";
        public static string FilterTextBox(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (!values.Contains(key[i]))
                {
                    key = key.Replace($"{key[i]}", String.Empty);
                    i--;
                }
            }
            return key;
        }

        public static void GenerateKey(string tempKey)
        {
            if (FileContext.bufferBinary == null)
            {
                return;
            }

            key = new string[FileContext.bufferBinary.Length];

            for (int i = 0, index = 0; i < FileContext.bufferBinary.Length; i++)
            {
                for (int j = 0; j < FileContext.bufferBinary[i].Length; j++, index++)
                {
                    key[i] += tempKey[index];

                    if (index + 1 == tempKey.Length)
                        index = -1;
                }
            }
            RegisterContext.key = key;
        }

        internal static void ConvertBinaryToDigits()
        {
            if (key == null)
                return;

            keyDigit = new byte[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                byte exponent = 0;
                byte result = 0;

                for (int j = key[i].Length - 1; j >= 0; j--)
                {
                    if (key[i][j] == '1')
                        result += Convert.ToByte(Math.Pow(2, exponent));
                    exponent++;
                }
                keyDigit[i] = result;
            }
        }

        internal static void Save(string path)
        {
            try
            {
                ConvertBinaryToDigits();

                if (keyDigit == null)
                    return;

                using (Stream file = File.OpenWrite(@$"{path}"))
                {
                    file.Write(keyDigit, 0, keyDigit.Length);
                }
                MessageBox.Show("Saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void TakeBytesFromPath(string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(@$"{path}", FileMode.Open))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);

                    bufferKeyDigit = buffer;
                }
            }
            catch (Exception ex)
            {
                bufferKeyDigit = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void ConvertBytesToBinary()
        {
            if (bufferKeyDigit == null)
                return;

            string[] result = new string[bufferKeyDigit.Length];

            for (int i = 0; i < bufferKeyDigit.Length; i++)
            {
                string binaryNumber = string.Empty;

                while (bufferKeyDigit[i] > 0)
                {
                    binaryNumber = (bufferKeyDigit[i] % 2) + binaryNumber;
                    bufferKeyDigit[i] /= 2;
                }
                result[i] = binaryNumber == String.Empty ? "0" : binaryNumber;
            }
            bufferKeyBinary = result;
            RegisterContext.key = bufferKeyBinary;
        }
    }
}
