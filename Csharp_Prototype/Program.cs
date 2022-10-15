using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Prototype
{
    internal class Program
    {       

        static void Main(string[] args)
        {
            var john = EmployeeFactory.NewMainOfficeEmployee("John", 100);
            var den = EmployeeFactory.NewLiverpulEmployee("Den", 147);

            Console.WriteLine($@"{john.Name} {john.WorkAddress.City}");
            Console.WriteLine($@"{den.Name} {den.WorkAddress.City}");
            Console.ReadKey();  
        }
    }
}
