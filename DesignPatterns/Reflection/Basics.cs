using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace DesignPatterns.Reflection
{
    public class Basics
    {
        public static void DriverMethod()
        {
            string FQCN = typeof(Customer).FullName;
            Type type = Type.GetType(FQCN);
            PropertyInfo[] properties = Type.GetType(FQCN).GetProperties();
            Console.WriteLine("{0,-50}{1}","Fully Qualified Class Name: ",type.FullName);
            Console.WriteLine("{0,-50}{1}", "Class Name", type.Name);
            Console.WriteLine("{0,-50}{1}", "Assembly Name: ", type.Assembly);
            Console.WriteLine("{0,-50}{1}", "Base Type class:", type.BaseType.Name);
            Console.WriteLine("{0,-50}{1}", "is this class Abstract: ", type.IsAbstract);
            Console.WriteLine("{0,-50}{1}", "is Customer Type interface", type.IsInterface);
            Console.WriteLine("{0,-50}{1}", "is Customer Class public: ", !type.IsNotPublic);
            Console.WriteLine("{0,-50}{1}", "NameSpace of Customer class :", type.Namespace);
            Console.WriteLine("\n-------Customer Fields---------\n");
            FieldInfo[] fieldInfo = type.GetFields();
            foreach (FieldInfo info in fieldInfo)
            {
                Console.WriteLine(info.FieldType+" "+info.Name);
            }
            Console.WriteLine("\n---------Customer class Properties are--------\n");
            foreach (PropertyInfo info in properties)
            {
                Console.WriteLine(info.PropertyType.FullName + " " + info.Name);
            }
            Console.WriteLine("\n-------------Customer class Methods---------------\n");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo info in methods)
            {
                Console.WriteLine(info.ReturnType+" "+info.Name);
            }
            Console.WriteLine("\n-------------Customer class Constructors--------------\n");
            ConstructorInfo[] cons = type.GetConstructors();
            foreach (ConstructorInfo info in cons)
            {
                Console.WriteLine(info.ToString());
            }
            Console.WriteLine("\n---Assemmblies upon which this Assembly dependant-----\n");
            AssemblyName[] arrr = type.Assembly.GetReferencedAssemblies();
            foreach (AssemblyName a in arrr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
