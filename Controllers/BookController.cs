// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Actions to control the books
    /// </summary>
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookManager bookManager;
        private readonly IConfiguration configuration;

        /// <summary>
        /// Parameterized constructor to inject the objects
        /// </summary>
        /// <param name="bookManager">bookManager</param>
        /// <param name="configuration">configuration</param>
        public BookController(IBookManager bookManager, IConfiguration configuration)
        {
            this.bookManager = bookManager;
            this.configuration = configuration;
        }

        /// <summary>
        /// To Add the book
        /// </summary>
        /// <param name="file">book cover Image</param>
        /// <param name="book">Books Model</param>
        /// <returns>result</returns>
        [HttpPost, Route("AddBook")]
        public async Task<IActionResult> AddBook(IFormFile file, Books book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (User.Identity.Name.Equals(configuration["Admin"]))
                    {
                        var result = await this.bookManager.AddBook(file, book);
                        if (result == 1)
                        {
                            return this.Ok("SuccessFully Added the Book");
                        }
                    }
                    else
                    {
                        return this.BadRequest("Only Admin Has the Permission To Add the Books");
                    }
                }
                catch (NullReferenceException ex)
                {
                    return this.BadRequest("Error in Login Try Again...!");
                }
            }
            return this.BadRequest("Failed Try Again");
        }

        /// <summary>
        /// to get the Books
        /// </summary>
        /// <returns>List of Books</returns>
        [HttpGet, Route("GetBooks")]
        public IActionResult GetBooks()
        {
            var BookList = this.bookManager.GetBooks();
            List<DisplayBook> books = new List<DisplayBook>();
            foreach (var book in BookList)
            {
                var stream = new MemoryStream(book.ImageContent);
                books.Add(new DisplayBook
                {
                    Author = book.Author,
                    BookId = book.BookId,
                    BookName = book.BookName,
                    Price = book.Price,
                    Stock = book.Stock,
                    ImageFile = File(book.ImageContent, book.ContentType)
                });
            }
            return this.Ok(books);
        }
    }
}
