using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_New
{
    class Program
    {
        public static void Main(string[] args)
        {
            TypeInfo info = new TypeInfo(typeof(TypeInfo));
            info.ShowMethod();
            info.ShowConstructors();
            info.ShowFields();
            info.ShowProperties();
            info.ShowInterfaces();

            Console.ReadLine();
        }
    }
}
