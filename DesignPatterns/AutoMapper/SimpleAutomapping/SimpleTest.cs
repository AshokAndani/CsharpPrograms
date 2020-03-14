// <copyright file="SimpleTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.SimpleAutomapping
{
    using global::AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is used to test the mapping
    /// </summary>
    public class SimpleTest
    {
        /// <summary>
        /// simple method to run without creating the object of this class
        /// </summary>
        public static void DriverMethod()
        {
            ////configuring the Mapper
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Customer, Employee>());

            //// creating the mapper Object
            IMapper mapper = configuration.CreateMapper();

            //// creating the Customer and filling the fields
            var customer = new Customer("Ashok", "Andani", 23, "Banglore");

            //// Assigning the mapped object
            var employee = mapper.Map<Employee>(customer);

            //// Printing the final mapped Object and normal object
            Console.WriteLine(customer.GetType().Name + "-------->\n" + customer + "\n----------------------------------------------\n");
            Console.WriteLine(employee.GetType().Name + "------->\n" + employee);
        }
    }
}
