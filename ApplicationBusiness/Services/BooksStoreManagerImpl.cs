// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookStoreManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.ApplicationBusiness.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.Models;
    using BookStore.Repository;

    /// <summary>
    /// to manage the account of bookstore users
    /// </summary>
    public class BooksStoreManagerImpl : IBookStoreManager
    {
        private readonly AppDbContext context;

        /// <summary>
        /// injecting the AppDbContext to constructor
        /// </summary>
        /// <param name="context">AppDbContext</param>
        public BooksStoreManagerImpl(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// to Cart the book 
        /// </summary>
        /// <param name="guid">book Id</param>
        /// <param name="UserName">UserName</param>
        /// <returns></returns>
        public async Task<int> CartBooks(Guid guid, string UserName)
        {
            try
            {
                await this.context.CartTable.AddAsync(new CartTable { BookID = guid, UserName = UserName });
                var result = await this.context.SaveChangesAsync();
                return result;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        /// <summary>
        /// gets the carted books
        /// </summary>
        /// <param name="UserName">UserName</param>
        /// <returns>List of books</returns>
        public List<Books> GetCartBooks(string UserName)
        {
            try
            {
                var books = this.context.Books.ToList();
                var CartList = this.context.CartTable.Where(t => t.UserName == UserName);
                var CartedBooks = books.Where(t => CartList.Any(u => u.BookID == t.BookId));
                return CartedBooks.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// to Add the Books to WishList
        /// </summary>
        /// <param name="guid">BookID</param>
        /// <param name="UserName">UserName</param>
        /// <returns>result</returns>
        public async Task<int> AddToWishList(Guid guid, string UserName)
        {
            try
            {
                await this.context.WishList.AddAsync(new WishList { BookID = guid, UserName = UserName });
                var result = await this.context.SaveChangesAsync();

                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// to get the wishlisted books
        /// </summary>
        /// <param name="UserName">UserName</param>
        /// <returns>List of Books</returns>
        public List<Books> GetWishList(string UserName)
        {
            try
            {
                var Allbooks = this.context.Books.ToList();
                var WishList = this.context.WishList.Where(t => t.UserName == UserName);
                var books = Allbooks.Where(t => WishList.Any(u => u.BookID == t.BookId));
                return books.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// To save the Order summary to the Database
        /// </summary>
        /// <param name="BookID">BookID</param>
        /// <param name="AddressID">AddressID</param>
        /// <param name="UserName">UserName</param>
        /// <returns>result</returns>
        public async Task<int> UpdateSummary(Guid BookID, Guid AddressID, string UserName)
        {
            try
            {
                await this.context.SummaryTable.AddAsync(new SummaryTable { AccountUserName = UserName, AddressID = AddressID, BookID = BookID });
                var result = await this.context.SaveChangesAsync();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
