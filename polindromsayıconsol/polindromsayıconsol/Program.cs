
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindromsayıconsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam = 0, sayi;
            Console.WriteLine("sayı gir: ");
            a=int.Parse(Console.ReadLine());
            sayi = a;
            while (a > 0)
            {
                b = a % 10;
                toplam = (toplam * 10) + b;
                a=a/ 10;
            }
            if (sayi == toplam)
            {
                Console.WriteLine("sayı polindrom");
            }
            else
            {
                Console.WriteLine("sayı polindrom değil");
            }
            Console.ReadLine();
        }
    }
}
