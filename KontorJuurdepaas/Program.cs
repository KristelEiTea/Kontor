using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontorJuurdepaas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kes olete teie? (number)");
            Console.WriteLine("1) Koristaja");
            Console.WriteLine("2) Nooremarendaja");
            Console.WriteLine("3) Vanemarendaja");
            Console.WriteLine("4) Spetsiaalkoristaja");
            Console.WriteLine("5) Andmetöötleja");
            Console.WriteLine("6) Ülemus");
            string amet = Console.ReadLine();
            while (true)
            {
                if (amet == "1")
                {
                    var koristaja = new Koristaja();
                    koristaja.Load();
                    break;
                }
                else if (amet == "2")
                {
                    var nooremarendaja = new Nooremarendaja();
                    nooremarendaja.Load();
                    break;
                }
                else if (amet == "3")
                {
                    var vanemarendaja = new Vanemarendaja();
                    vanemarendaja.Load();
                    break;
                }
                else if (amet == "4")
                {
                    var spetsiaalkoristaja = new Spetsiaalkoristaja();
                    spetsiaalkoristaja.Load();
                    break;
                }
                else if (amet == "5")
                {
                    var andmetootleja = new Andmetootleja();
                    andmetootleja.Load();
                    break;
                }
                else if (amet == "6")
                {
                    var ulemused = new Ulemused();
                    ulemused.Load();
                    break;
                }
                else continue;
            }
            Console.ReadKey();
        }
    }
}
