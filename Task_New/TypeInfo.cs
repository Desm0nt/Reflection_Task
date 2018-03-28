using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_New
{
    class TypeInfo
    {
        public Type LookedType { get; set; }
        public TypeInfo(Type currentType)
        {
            LookedType = currentType;
            Console.WriteLine(LookedType.ToString());
        }

        public void ShowMethod()
        {
            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in LookedType.GetMethods())
            {
                string mod = "";
                if (method.IsStatic)
                {
                    mod += "static ";
                }
                if (method.IsVirtual)
                {
                    mod += "virtual ";
                }
                Console.Write(mod + method.ReturnType.Name + " " + method.Name + " (");
                ParameterInfo[] param = method.GetParameters();
                for (int i = 0; i < param.Length; i++)
                {
                    Console.Write(param[i].ParameterType.Name + " " + param[i].Name);
                    if (i + 1 < param.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }

        public void ShowConstructors()
        {
            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo constr in LookedType.GetConstructors())
            {
                Console.Write(LookedType.Name + " (");
                ParameterInfo[] param = constr.GetParameters();
                for (int i = 0; i < param.Length; i++)
                {
                    Console.Write(param[i].ParameterType.Name + " " + param[i].Name);
                    if (i + 1 < param.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }

        public void ShowFields()
        {
            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in LookedType.GetFields())
            {
                Console.WriteLine("{0} {1}", field.FieldType, field.Name);
            }
        }

        public void ShowProperties()
        {
            Console.WriteLine("\nProperties:");
            foreach (PropertyInfo prop in LookedType.GetProperties())
            {
                Console.WriteLine("{0} {1}", prop.PropertyType, prop.Name);
            }
        }

        public void ShowInterfaces()
        {
            Console.WriteLine("\nInterfaces:");
            foreach (Type interf in LookedType.GetInterfaces())
            {
                Console.WriteLine(interf.Name);
            }
        }

    }
}
