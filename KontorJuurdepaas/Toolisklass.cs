using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontorJuurdepaas
{
    abstract class Toolisklass
    {
        protected bool ArendajateRuum;
        protected bool UlemusteRuum;
        protected bool Soogituba;
        protected bool AndmetootlejateRuum;
        protected bool Peauks;

        public virtual void Load()
        {
            Console.WriteLine("Teie load on: " + System.Environment.NewLine);
            Console.WriteLine("Arendajate ruum: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(ArendajateRuum);
            Console.ResetColor();
            Console.WriteLine("Ülemuste ruum: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(UlemusteRuum);
            Console.ResetColor();
            Console.WriteLine("Söögituba: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Soogituba);
            Console.ResetColor();
            Console.WriteLine("Andmetöötlejate ruum: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(AndmetootlejateRuum);
            Console.ResetColor();
            Console.WriteLine("Peauks: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Peauks);
            Console.ResetColor();
        }
    }
}
