using ITS.Core.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITS.Services.Contracts
{
    public interface IStepService
    {
        IList<Step> GetAllSteps();
        Step GetStep(long id);
        void AddStep(Step step);
        void RemoveStep(long id);
        void ArchiveStep(long id);
        void UpdateStep(Step step);
    }
}
