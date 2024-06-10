using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernameMax3Tries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string password = "";
            int tries = 3;
            while (tries > 0)
            {
                Console.Write("KULLANICI ADI: ");
                username = Console.ReadLine();
                if (username != "admin")
                {
                    tries--;
                    Console.Clear();
                }
                else
                {
                    Console.Write("ŞİFRE: ");
                    while (tries > 0)
                    {
                        password = Console.ReadLine();
                        if (password != "1234")
                        {
                            tries--;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Giriş Başarılı!");
                        }
                    }
                    Console.WriteLine("Üst üste 3 kere yanlış yaptığınız için hesabınız 5 milyon ışık yılı dondurulmuştur.");
                }
            }
            Console.WriteLine("Üst üste 3 kere yanlış yaptığınız için hesabınız 5 milyon ışık yılı dondurulmuştur.");
        }
    }
}
