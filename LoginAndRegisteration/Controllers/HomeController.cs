// <copyright file="HomeController" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ChatApp.Models;

    /// <summary>
    /// this class is the example class for managing the user inventory
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// this field creates the the UserRepo which has the CRUD opertations 
        /// </summary>
        private IUserRepo repo;

        /// <summary>
        /// parameterised constructor for DE
        /// </summary>
        /// <param name="repo"></param>
        public HomeController(IUserRepo repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// using authorize it ensures the neccessary operations to be done only by logged in user
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// this action is for creating the new user in inventory
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public IActionResult Creating(User user)
        {
            if(ModelState.IsValid)
            {
                repo.Add(user);
            }
            return View();
        }

        /// <summary>
        /// this action deletes the existing user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public IActionResult Delete(int id)
        { 
            if(this.repo!=null)
            {
                this.repo.Delete(id);
            }
            return RedirectToAction("List");
        }

        /// <summary>
        /// to View the Details about the selected User in inventory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            var user = this.repo.GetUser(id);
            return View(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public IActionResult Edit(int id)
        {
            var user = this.repo.GetUser(id);
            return View(user);
        }

        /// <summary>
        /// this action takes to HomePage
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// this action takes to the List of the users in inventory
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            var list = repo.GetUsers();
            return View(list);
        }
    }
}
