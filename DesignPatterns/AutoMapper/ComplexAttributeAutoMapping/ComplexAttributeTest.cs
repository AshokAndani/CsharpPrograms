// <copyright file="ComplexAttributeTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>


namespace DesignPatterns.AutoMapper.ComplexAttributeAutoMapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AutoMapper;
    using global::AutoMapper;

    /// <summary>
    /// this class is used to test the Complex mapping
    /// </summary>
    public class ComplexAttributeTest
    {
        public static void DriverMethod()
        {
            Console.WriteLine("--------------------------Before Mapping inner class Attributes----------------------------");
           //// configuring the auto mapper
            var config = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Address, AddressDTO>();
                        c.CreateMap<Customer, Employee>()
                        .ForMember(n => n.address, o => o.MapFrom(s => s.address));
                    });

            //// creating the mapper object
            var mapper = config.CreateMapper();

            //// creating the Address and filling the fields
            Address ad = new Address("Banglore", "Karnataka", "India");
            var customer = new Customer("Ashok");
            customer.address = ad;

            //// Now filling the Employee Object fields with the Customer fields by Mapper without mapping the Attributes
            var emp = mapper.Map<Customer, Employee>(customer);
            Console.WriteLine(customer);
            Console.WriteLine(emp);
            
            //// Mapping the Fields before filling the Employee object with the Customer object Fields
            var nconfig = new MapperConfiguration(c =>
            {
                c.CreateMap<Address, AddressDTO>()
                .ForMember(n => n.HomeTown, o => o.MapFrom(s => s.city));
                c.CreateMap<Customer, Employee>();
            });
            mapper = nconfig.CreateMapper();

            //// printing the Customer object and the Employee Object
            var employee = mapper.Map<Customer, Employee>(customer);
            Console.WriteLine("\n-----------------------After mapping the inner class Attributes--------------\n");
            Console.WriteLine(customer);
            Console.WriteLine(employee);

        }
    }
}
