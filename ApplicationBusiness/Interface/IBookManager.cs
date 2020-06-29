// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookManager.cs" company="Bridgelabz">
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
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// to Manager the books
    /// </summary>
    public interface IBookManager
    {

        /// <summary>
        /// to add the new books to the Store
        /// </summary>
        /// <param name="file">Book Image</param>
        /// <param name="book">Book information Model</param>
        /// <returns>result</returns>
        Task<int> AddBook(IFormFile file, Books book);

        /// <summary>
        /// to get the books available in the Store
        /// </summary>
        /// <returns>List of books</returns>
        List<Books> GetBooks();
    }
}
