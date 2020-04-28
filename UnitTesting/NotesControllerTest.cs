namespace UnitTesting
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;
    using ApplicationBusiness.Interfaces;
    using Common.Models;
    using FundooAPI.Controllers;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Common.ControllerModels;

    /// <summary>
    /// this class is to test the NotesController
    /// </summary>
    public class NotesControllerTest
    {
        /// <summary>
        /// this method tests the AddNotes
        /// </summary>
        [Fact]
        public void AddNote_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);
            var model = new AddNoteModel
            {
                Colour = "Yellow",
                Description = "Sample Description",
                Reminder = "Nothing to remember",
                Title = "TestTitle"
            };
            IFormFile file = null;
            //// Act
            var result = controller.AddNote(file, model);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// this method tests the Update notes
        /// </summary>
        [Fact]
        public void UpdateNote_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);
            var model = new UpdateNoteModel
            {
                Colour = "Yellow",
                Description = "Sample Description",
                Reminder = "Nothing to remember",
                Title = "TestTitle"
            };
            IFormFile file= null;
            //// Act
            var result = controller.UpdateNote(file,model);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// this method tests the GetNotes action
        /// </summary>
        [Fact]
        public void GetNote_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.GetNote(11);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// this method tests the GetAllNotes
        /// </summary>
        [Fact]
        public void GetAllNotes_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.GetNotes();
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// Tests the Trash action
        /// </summary>
        [Fact]
        public void Trash_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.Trash(11);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// Tests Archive Action
        /// </summary>
        [Fact]
        public void Archive_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.Archive(11);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// Tests the Pin/unPin action
        /// </summary>
        [Fact]
        public void Pin_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.Pin(1);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// Tests the AddCollaborator action
        /// </summary>
        [Fact]
        public void AddCollaborator_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);
            //// Act
            var result = controller.AddCollaborator("ashok@gmail.com",3);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        /// <summary>
        /// Tests the RemoveCollaborator action
        /// </summary>
        [Fact]
        public void RemoveCollaborator_Return_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);
            //// Act
            var result = controller.RemoveCollaborator(11, "ashok@gmail.com");
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
