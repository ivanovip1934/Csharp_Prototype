using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Prototype
{

    [Serializable]
    public class Contact
    {
        public string Name;
        public Address WorkAddress;
    }
    [Serializable]
    public class Address
    {
        public string Street;
        public string City;
        public int Suite;
    }
    internal class EmployeeFactory
    {
        private static Contact mainoffice = new Contact
            {
                Name = "John",
                WorkAddress = new Address { City = "London", Street = "221B Baker St", Suite = 100 }
            };
        private static Contact liverpul = new Contact
        {
            Name = "John",
            WorkAddress = new Address { City = "Liverpul", Street = "221B Baker St", Suite = 100 }
        };
        static Contact NewEmployee(Contact prototype,string Name, int Suite)
        {
            var result = prototype.DeepCopy();
            result.Name = Name;
            result.WorkAddress.Suite = Suite;
            return result;
        }

        public static Contact NewMainOfficeEmployee(string Name,int Suite) 
        { 
            return NewEmployee(mainoffice, Name,Suite);
        }
        public static Contact NewLiverpulEmployee(string Name, int Suite)
        {
            return NewEmployee(liverpul, Name, Suite);
        }
    }
}
