using ITS.Core.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITS.Core.IRepository
{
    public interface IStepRepository : IBaseRepository<Step>
    {
        void AddStep(Step step);
        void RemoveStep(long id);
        void ArchiveStep(long id);
        void UpdateStep(Step step);
    }
}
