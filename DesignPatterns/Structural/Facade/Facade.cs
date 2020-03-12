// <copyright file="Facade.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Facade
{
    using System;

    /// <summary>
    /// this class is the Facade class which wraps the Complex classes and interfaces and makes it easy for the client
    /// </summary>
    public class Facade
    {
        private CarBody carBody { get; set; }
        private CarAccessories carAccessories { get; set; }
        private CarEngine carEngine { get; set; }
        private CarModel carModel { get; set; }

        /// <summary>
        /// constructor for initializing the variables
        /// </summary>
        public Facade()
        {
            this.carBody = new CarBody();
            this.carAccessories = new CarAccessories();
            this.carEngine = new CarEngine();
            this.carModel = new CarModel();
        }

        /// <summary>
        /// this method can be accessed by client which internally calls the methods of the sub-system classes
        /// </summary>
        public void MakeCar()
        {
            this.carModel.GetModel();
            this.carBody.GetCarBody();
            this.carEngine.GetEngine();
            this.carAccessories.GetAccessories();
        }
    }
}
