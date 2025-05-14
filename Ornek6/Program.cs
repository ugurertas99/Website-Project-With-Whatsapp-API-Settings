using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            string kalinHarfler = "AIOUaıou";
            string inceHarfler = "EİÖÜeiöü";

            Console.Write("Kelime Giriniz: ");

            kelime = Console.ReadLine();

            bool ince = false;
            bool kalin = false;


            foreach (char harf  in kelime)
            {
                if (inceHarfler.IndexOf(harf) == -1)
                {
                    ince = true;
                }
                if (kalinHarfler.IndexOf(harf) !=-1)
                {
                    kalin = true;
                }
            }

            if(ince && kalin)
            {
                Console.WriteLine("Büyük ünlü uyumuna uymuyor");
            }
            else
            {
                Console.WriteLine("Büyük ünlü uyumuna uyuyor");
            }
        }
    }
}
