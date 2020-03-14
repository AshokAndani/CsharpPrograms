// <copyright file="ComplexTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexAutomapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AutoMapper;
    using global::AutoMapper;

    /// <summary>
    ///  this class is to check the Complex Mapping 
    /// </summary>
    public class ComplexTest
    {
        /// <summary>
        /// simple method to run the code without creating the object of this class
        /// </summary>
        public static void DriverMethod()
        {
            var config = new MapperConfiguration(
                cc =>
                {
                    cc.CreateMap<AddressDAO, AddressDTO>();
                    cc.CreateMap<Customer, Employee>()
                    .ForMember(n => n.address, o => o.MapFrom(s => s.address));
                }
                );

            var mapper = config.CreateMapper();

            //// creating the Address and Customer objects and filling them
            AddressDAO ad = new AddressDAO("Banglore", "Karnataka", "India");
            Customer customer = new Customer("ashok");
            customer.address = ad;

            //// print the Both Objects by mapping the Employee Object
            var employee = mapper.Map<Customer, Employee>(customer);
            Console.WriteLine(customer);
            Console.WriteLine(employee);
        }

        /// <summary>
        /// to get mapper with mapped attributes 
        /// </summary>
        /// <returns></returns>
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Customer, Employee>()
            .ForMember(n => n.address, o => o.MapFrom(m => m.address)));
            return config.CreateMapper();
        }
    }
}
