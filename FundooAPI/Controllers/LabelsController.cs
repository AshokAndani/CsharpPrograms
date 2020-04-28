// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelsController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using ApplicationBusiness.Interfaces;
    using Common.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// this is the Labels Controller class
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    public class LabelsController : Controller
    {
        /// <summary>
        /// LabelManager to manager the labels
        /// </summary>
        private readonly ILabelManager labelManager;

        /// <summary>
        /// Constructor injection of LabelsManager
        /// </summary>
        /// <param name="labelManager">DE of LabelsManager</param>
        public LabelsController(ILabelManager labelManager)
        {
            this.labelManager = labelManager;
        }

        /// <summary>
        /// Adds the new Label
        /// </summary>
        /// <param name="model">from body</param>
        /// <returns>Result</returns>
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add([FromBody]LabelsModel model)
        {
            if (ModelState.IsValid)
            {
                string currentUser;
                try
                {
                    currentUser = this.User.Identity.Name;
                }
                catch(Exception e)
                {
                    currentUser = null;
                }
                model.Email = currentUser;
                var result = await this.labelManager.AddLabel(model);
                if (result==1)
                {
                    return Ok(result);
                }
                return this.NotFound(result);
             }
            return this.BadRequest();
        }

        /// <summary>
        /// updates the label
        /// </summary>
        /// <param name="model">from body</param>
        /// <returns>Result</returns>
        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody]LabelsModel model)
        {
            if (ModelState.IsValid)
            {
                string currentUser;
                try
                {
                    currentUser = this.User.Identity.Name;
                }
                catch(Exception e)
                {
                    currentUser = null;
                }
                model.Email = currentUser;
                var result = await this.labelManager.UpdateLabel(model);
                return Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// Gets the Label based on the id
        /// </summary>
        /// <param name="id">from body</param>
        /// <returns>Result</returns>
        [HttpPost, Route("get")]
        public IActionResult Get([FromBody]int id)
        {
            string currentUser;
            try
            {
                currentUser = this.User.Identity.Name;
            }
            catch (Exception e)
            {
                currentUser = null;
            }
            var model = this.labelManager.GetLabel(id,currentUser);
            if (model != null)
            {
            return this.Ok(model);
            }
            return this.NotFound();
        }

        /// <summary>
        /// Deletes the Label
        /// </summary>
        /// <param name="id">from body</param>
        /// <returns>Result</returns>
        [HttpDelete, Route("delete")]
        public async Task<IActionResult> Delete([FromBody]int id)
        {
            string currentUser;
            try
            {
                currentUser = this.User.Identity.Name;
            }
            catch (Exception e)
            {
                currentUser = null;
            }
            var result = await this.labelManager.DeleteLabel(id, currentUser);
            if (result == 1)
            {
                return this.Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// gets all the labels
        /// </summary>
        /// <returns>Result</returns>
        [HttpPost, Route("getall")]
        public IActionResult GetAll()
        {
            string currentUser;
            try
            {
                currentUser = this.User.Identity.Name;
            }
            catch (Exception e)
            {
                currentUser = null;
            }
            var result = this.labelManager.GetAllLabels(currentUser);
            if (result != null)
            {
                return Ok(result);
            }
            return this.NotFound();
        }
    }
}
