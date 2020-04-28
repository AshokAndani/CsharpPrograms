// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILabelsRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationRepository.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Models;

    /// <summary>
    /// this interface provides the methods for managing the Labels
    /// </summary>
    public interface ILabelsRepository
    {
        Task<int> AddLabel(LabelsModel model);
        LabelsModel GetLabel(int id, string email);
        IEnumerable<LabelsModel> GetAllLabels(string email);
        Task<int> UpdateLabel(LabelsModel model);
        Task<int> DeleteLabel(int Id, string email);
    }
}
