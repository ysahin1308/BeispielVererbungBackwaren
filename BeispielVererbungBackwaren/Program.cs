using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielVererbungBackwaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Brot dinkel = new Brot("Dinkelbrot",2.45,"Dinkelmehl",750.00);
            Console.WriteLine($"{dinkel.Name} : {dinkel.Verkaufspreis} €");
        }
    }
}
