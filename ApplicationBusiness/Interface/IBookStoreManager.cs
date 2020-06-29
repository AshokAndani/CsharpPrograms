// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookStoreManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.ApplicationBusiness.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.Models;

    /// <summary>
    /// IBookStoreManager
    /// </summary>
    public interface IBookStoreManager
    {
        Task<int> CartBooks(Guid guid, string UserName);
        List<Books> GetCartBooks(string UserName);
        Task<int> AddToWishList(Guid guid, string UserName);
        List<Books> GetWishList(string UserName);
        Task<int> UpdateSummary(Guid BookID, Guid AddressID, string UserName);
    }
}
