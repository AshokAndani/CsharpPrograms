// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILabelManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationBusiness.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Models;

    /// <summary>
    /// To Manage the Labels
    /// </summary>
    public interface ILabelManager
    {
        Task<int> AddLabel(LabelsModel model);
        Task<int> DeleteLabel(int id);
        Task<int> UpdateLabel(LabelsModel model);
        IEnumerable<LabelsModel> GetAllLabels();
        LabelsModel GetLabel(int id);
    }
}
