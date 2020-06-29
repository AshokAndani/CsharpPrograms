// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookAccountController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.Repository;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// to handle the bookstore User Account
    /// </summary>
    public class BookAccountController : Controller
    {
        private readonly IBookStoreManager manager;
        public BookAccountController(IBookStoreManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// To Cart the Books
        /// </summary>
        /// <param name="guid">BookID</param>
        /// <returns>result</returns>
        [HttpGet, Route("CartBooks")]
        public async Task<IActionResult> CartBooks(Guid guid)
        {
            try
            {
                var user = User.Identity.Name;
                var result = await this.manager.CartBooks(guid, user);
                if (result == 1)
                {
                    return this.Ok("Added to Cart");
                }
                return this.BadRequest("Failled to Added Try Again");

            }
            catch (NullReferenceException)
            {
                return this.BadRequest("Error While Adding to Cart");
            }
        }

        /// <summary>
        /// to get the Carted the books
        /// </summary>
        /// <returns>result</returns>
        [HttpGet, Route("GetCartBooks")]
        public IActionResult GetCartBooks()
        {
            try
            {
                var user = User.Identity.Name;
                var CartedBooks = this.manager.GetCartBooks(user);
                return this.Ok(CartedBooks);
            }
            catch (NullReferenceException)
            {
                return this.BadRequest("Error in login try logging again..!");
            }
        }

        /// <summary>
        /// to Add the Book to the WishList
        /// </summary>
        /// <param name="guid">BookID</param>
        /// <returns>Result</returns>
        [HttpGet, Route("AddToWishList")]
        public async Task<IActionResult> AddToWishList(Guid guid)
        {
            try
            {
                var user = User.Identity.Name;
                var result = await this.manager.AddToWishList(guid, user);
                if (result == 1)
                {
                    return this.Ok("Added to WishList");
                }
                return this.BadRequest("Failed to Add");
            }
            catch (NullReferenceException)
            {
                return this.BadRequest("Login Error try Logging Again..!");
            }
        }

        /// <summary>
        /// To get the WishListed Books 
        /// </summary>
        /// <returns>List of books</returns>
        [HttpGet, Route("GetWishList")]
        public IActionResult GetWishList()
        {
            try
            {
                var user = User.Identity.Name;
                var books = this.manager.GetWishList(user);
                return this.Ok(books);
            }
            catch (NullReferenceException)
            {
                return this.BadRequest("Error While Logging in Login again..!");
            }
        }

        /// <summary>
        /// to update the Smmary table
        /// </summary>
        /// <param name="BookID">BookID</param>
        /// <param name="AddressID">AddressID</param>
        /// <returns></returns>
        [HttpGet, Route("UpdateSummary")]
        public async Task<IActionResult> UpdateSummary(Guid BookID, Guid AddressID)
        {
            try
            {
                var user = User.Identity.Name;
                var result = await this.manager.UpdateSummary(BookID, AddressID, user);
                if (result == 1)
                {
                    return this.Ok("Successfully Added");
                }
                return this.BadRequest("Failed");
            }
            catch (NullReferenceException)
            {
                return this.BadRequest("Failed");
            }
        }
    }
}
