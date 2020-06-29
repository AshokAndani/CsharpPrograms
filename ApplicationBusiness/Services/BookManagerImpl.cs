// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.ApplicationBusiness.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.Models;
    using BookStore.Repository;
    using Microsoft.AspNetCore.Http;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    /// <summary>
    /// to manager the Books
    /// </summary>
    public class BookManagerImpl : IBookManager
    {
        private readonly AppDbContext context;

        public BookManagerImpl(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// to get the books
        /// </summary>
        /// <returns>List of books model</returns>
        public List<Books> GetBooks()
        {
            return this.context.Books.ToList();
        }

        /// <summary>
        /// to Add the Book
        /// </summary>
        /// <param name="file">Book cover image</param>
        /// <param name="book">Books Model</param>
        /// <returns>result</returns>
        public async Task<int> AddBook(IFormFile file, Books book)
        {
            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            book.ImageContent = stream.ToArray();
            book.ImageName = file.FileName;
            book.ContentType = file.ContentType;
            await this.context.Books.AddAsync(book);
            var result = await this.context.SaveChangesAsync();
            return result;
        }
    }
}
