// <copyright file="ToPrimitiveTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexTypeToPrimitive
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using global::AutoMapper;

    /// <summary>
    /// this class is to test the Mapped Classes
    /// </summary>
    public class ToPrimitiveTest
    {
        /// <summary>
        /// simple method to run the code without creating this class Object
        /// </summary>
        public static void DriverMethod()
        {
            //// creating the MapperConfiguration Object for mapper
            var config = new MapperConfiguration(c =>
            c.CreateMap<Customer, Employee>()
            .ForMember(n => n.City, o => o.MapFrom(s => s.address.city))
            .ForMember(n => n.Country, o => o.MapFrom(s => s.address.country))
            .ForMember(n => n.State, o => o.MapFrom(s => s.address.state)));

            //// creating the mapper Object
            var mapper = config.CreateMapper();

            //// creating and filling the Address and Customer class Objects
            Address address = new Address("Banglore", "Karnataka", "India");
            Customer customer = new Customer("Ashok");
            customer.address = address;

            //// Copying the mapped fields from the Customer Object to Employee Object
            var employee = mapper.Map<Customer, Employee>(customer);
            Console.WriteLine("Converted the address attributes to Employee attributes through Mapping");

            //// printing the both objects
            Console.WriteLine(customer);
            Console.WriteLine(employee);
        }
    }
}
