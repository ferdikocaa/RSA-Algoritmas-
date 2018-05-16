using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider MyRsa = new RSACryptoServiceProvider();
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();//diziyi ascii kodlara dönüştürüyoruz.
            string data = "Ferdi KOCA Bilgi guvenligi  ve kriptoloji odevi";//şifrelemek istediğim mesaj
            Byte[] newdata = encoding.GetBytes(data);//mesajı byte çeviriyoruz.
            Byte[] encrypted = MyRsa.Encrypt(newdata, false);
            Console.WriteLine("Şifrelenmiş Metin  ");
            for (int i = 0; i < encrypted.Length; i++)
            {
                Console.Write("{0} ", encrypted[i]);
            }
            Console.WriteLine();
            Byte[] decrypted = MyRsa.Decrypt(encrypted, false);//decrypt 
            Console.WriteLine("Çözülmüş Metin:  ");
            string dData = encoding.GetString(decrypted); //bytlerı diziye geri çeviriyoruz.
            for (int i = 0; i < decrypted.Length; i++)
            {
                Console.Write("{0}", dData[i]);
            }
            Console.ReadKey();

        }
    }
}
