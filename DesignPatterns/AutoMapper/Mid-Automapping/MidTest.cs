// <copyright file="MidTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.Mid_Automapping
{
    using global::AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to the mapping 
    /// </summary>
    public class MidTest
    {
        /// <summary>
        /// simple static method to run the code without creating the object of this class
        /// </summary>
        public static void DriverMethod()
        {
            ////creating the mapper configuration object
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, Employee>());

            //// creating the mapper Object
            var mapper = config.CreateMapper();

            //// creating the Customer class and filling them
            var customer = new Customer("Ashok", "Andani", 23, "Banglore");

            //// created the employee object by mapping
            var employee = mapper.Map<Employee>(customer);

            //// Printing the both the Objects
            Console.WriteLine("Without Mapping attributes---->\n" + customer + "\n" + employee);
            Console.WriteLine("After Mapping the Attributes");

            //// now mapping the Objects with the Fields
            config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, Employee>()
            .ForMember(n => n.Name, o => o.MapFrom(m => m.FirstName + " " + m.LastName))
            .ForMember(n => n.CurrentAge, o => o.MapFrom(m => m.Age))
            .ForMember(n => n.HomeTown, o => o.MapFrom(m => m.City)));

            //// creating the Mapper Object
            mapper = config.CreateMapper();

            //// assining the mapped object as Employee
            employee = mapper.Map<Employee>(customer);

            //// Printing the final Objects
            Console.WriteLine(customer);
            Console.WriteLine(employee);
        }
    }
}
