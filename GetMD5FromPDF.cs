//request
//code on C# to get MD5 hash from *.pdf

//You can use the System.Security.Cryptography namespace in C# to calculate the MD5 hash of a PDF file. Here's an example code:

using System;
using System.IO;
using System.Security.Cryptography;

namespace MyApplication
{
    public class Program
    {
        static void Main()
        {
            string pdfFilePath = "path/to/your/file.pdf";

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(pdfFilePath))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    string md5Hash = BitConverter.ToString(hash).Replace("-", "").ToLower();
                    Console.WriteLine("MD5 hash of the file: {0}", md5Hash);
                }
            }
        }
    }
}

/*In this code, we first specify the path to the PDF file we want to calculate the MD5 hash for.
 * Then, we create an instance of the MD5 class and use its ComputeHash method to calculate the hash for the file.
 * Finally, we convert the byte array hash into a string format and print it to the console.

Note that this code assumes that the PDF file exists and is accessible at the specified file path.
If the file does not exist or the path is invalid, an exception will be thrown.
*/