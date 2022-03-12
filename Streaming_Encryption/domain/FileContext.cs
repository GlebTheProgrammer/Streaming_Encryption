using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_Encryption.domain
{
    internal static class FileContext
    {
        public static byte[]? bufferDigit = null;
        public static string[]? bufferBinary = null;
        public static string[]? bufferEncryptDecryptBinary = null;
        public static byte[]? bufferEncryptDecryptDigit = null;
        internal static void TakeBytesFromPath(string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(@$"{path}", FileMode.Open))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);
                    
                    bufferDigit = buffer;
                }
            }
            catch (Exception ex)
            {
                bufferDigit = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        internal static void ConvertBytesToBinary()
        {
            if (bufferDigit == null)
                return;

            string[] result = new string[bufferDigit.Length];

            for (int i = 0; i < bufferDigit.Length; i++)
            {
                string binaryNumber = string.Empty;

                while (bufferDigit[i] > 0)
                {
                    binaryNumber = (bufferDigit[i] % 2) + binaryNumber;
                    bufferDigit[i] /= 2;
                }
                result[i] = binaryNumber == String.Empty ? "0" : binaryNumber;
            }
            bufferBinary = result;
        }

        internal static void EncryptDecryptFile()
        {
            if (bufferBinary == null || RegisterContext.key == null)
                return;

            bufferEncryptDecryptBinary = new string[bufferBinary.Length];

            for (int i = 0; i < bufferBinary.Length; i++)
            {
                while (bufferBinary[i].Length != RegisterContext.key[i].Length)
                {
                    if (bufferBinary[i].Length > RegisterContext.key[i].Length)
                        RegisterContext.key[i] = '0' + RegisterContext.key[i];
                    if (bufferBinary[i].Length < RegisterContext.key[i].Length)
                        bufferBinary[i] = '0' + bufferBinary[i];
                }
                for (int j = 0; j < bufferBinary[i].Length; j++)
                {
                    bufferEncryptDecryptBinary[i] += Convert.ToInt32(bufferBinary[i][j]) ^ 
                                                     Convert.ToInt32(RegisterContext.key[i][j]);
                }
            }
        }

        internal static void ConvertBinaryToDigits()
        {
            if (bufferEncryptDecryptBinary == null)
                return;

            bufferEncryptDecryptDigit = new byte[bufferEncryptDecryptBinary.Length];

            for (int i = 0; i < bufferEncryptDecryptBinary.Length; i++)
            {
                byte exponent = 0;
                byte result = 0;

                for(int j = bufferEncryptDecryptBinary[i].Length - 1; j >= 0; j--)
                {
                    if (bufferEncryptDecryptBinary[i][j] == '1')
                        result += Convert.ToByte(Math.Pow(2,exponent));
                    exponent++;
                }
                bufferEncryptDecryptDigit[i] = result;
            }
        }

        internal static void Save(string path)
        {
            try
            {
                ConvertBinaryToDigits();

                if (bufferEncryptDecryptDigit == null)
                    return;

                using (Stream file = File.OpenWrite(@$"{path}"))
                {
                    file.Write(bufferEncryptDecryptDigit, 0, bufferEncryptDecryptDigit.Length);
                }
                MessageBox.Show("Saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }
    }
}
