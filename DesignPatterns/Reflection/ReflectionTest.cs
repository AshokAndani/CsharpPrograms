using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace DesignPatterns.Reflection
{
    class ReflectionTest
    {
        public static void DriverMethod()
        {
            Console.WriteLine("------------------This is by Early Binding----------------------");
            Customer c = new Customer();
            string fname=c.GetFullName("Ashok", "Andani");
            Console.WriteLine(fname);
            string classname =typeof(Customer).FullName;
           
            Console.WriteLine("---------------This is by Late Binding using Reflection-----------");
            
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type customertype = assembly.GetType(classname);
            Object customer = Activator.CreateInstance(customertype);
            string[] arr = {"Ashok","Andani" };
            MethodInfo method = customertype.GetMethod("GetFullName");
            string fullname =(string) method.Invoke(customer, arr);
            Console.WriteLine(fullname);
        }
    }
}
