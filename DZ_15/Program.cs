using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Type console = typeof(Console);
            MethodInfo[] methods = console.GetMethods();
            Console.WriteLine("Список методов класса Console: \n");
            foreach (MethodInfo m in methods)
            {
                Console.Write(m.ReturnType.Name + "\t" + m.Name);
                Console.Write("\n");
            }
            Console.ReadLine();   
            
            Man man = new Man()
            {
                Name = "Rus",
                Age = 36,
                City = "Astana"
            };
            Type type = typeof(Man);
            Console.WriteLine("Тип: " + type.Name);
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Методы: ");
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + ":\t" + property.Name);
            }
            Console.Read();            
        }
    }    
}
