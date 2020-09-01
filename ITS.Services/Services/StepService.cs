using ITS.Core.DBEntity;
using ITS.Core.IRepository;
using ITS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITS.Services.Services
{
    public class StepService : IStepService
    {
        private readonly IStepRepository _stepRepository;
        public StepService(IStepRepository stepRepository)
        {
            _stepRepository = stepRepository;
        }
        public IList<Step> GetAllSteps()
        {
            return _stepRepository.GetAllByFilter(x => x.IsActive == true).ToList();
        }

        public Step GetStep(long id)
        {
            return _stepRepository.GetById(id);
        }
        public IList<Step> AddStep()
        {
            _stepRepository.AddStep();
            return GetAllSteps();
        }
        public IList<Step> ArchiveStep(long id)
        {
            _stepRepository.ArchiveStep(id);
            return GetAllSteps();
        }
        public void UpdateStep(Step step)
        {
            _stepRepository.UpdateStep(step);
        }
        public void RemoveStep(long id)
        {
            _stepRepository.RemoveStep(id);
        }
        
    }
}
