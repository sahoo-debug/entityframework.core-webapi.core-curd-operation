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
        IList<Step> AddStep();
        IList<Step> ArchiveStep(long id);
        void UpdateStep(Step step);
        void RemoveStep(long id);
        
    }
}
