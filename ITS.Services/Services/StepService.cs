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
            return _stepRepository.GetAll().ToList();
        }

        public Step GetStep(long id)
        {
            return _stepRepository.GetById(id);
        }
        public void AddStep(Step step)
        {
            _stepRepository.AddStep(step);
        }
        public void RemoveStep(long id)
        {
            _stepRepository.RemoveStep(id);
        }
        public void ArchiveStep(long id)
        {
            _stepRepository.ArchiveStep(id);
        }
        public void UpdateStep(Step step)
        {
            _stepRepository.UpdateStep(step);
        }
    }
}
