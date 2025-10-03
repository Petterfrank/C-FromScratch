using System.Windows.Markup;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaracion
            int number;
            String name;

            //Variable inicializacion

            number = 10;
            name = "John Doe";

            //Implicitly typed variable
            
            var isActive = true;
            var pi = 3.14;
            var city = "New York";

            Console.WriteLine($"Number: {number}, Name:{name}");
        }
    }
}
