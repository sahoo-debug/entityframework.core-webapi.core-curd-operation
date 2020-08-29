using ITS.Core.DBEntity;
using ITS.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITS.Core.Repository
{
    public class StepRepository : BaseRepository<Step>, IStepRepository
    {
        protected SKSTestDBContext _context;
        public StepRepository(SKSTestDBContext context) : base(context)
        {
            _context = context;
        }

        public void AddStep(Step step)
        {
            step.IsActive = true;
            Add(step);
        }
        public void RemoveStep(long id)
        {
            var entity = _context.Step.Where(x=>x.StepId == id).FirstOrDefault();
            Remove(entity);
        }

        public void ArchiveStep(long id)
        {
            var entity = _context.Step.Where(x => x.StepId == id).FirstOrDefault();
            if (entity != null)
            {
                entity.IsActive = false;
                Update(entity);
            }
        }
        public void UpdateStep(Step step)
        {
            var entity = _context.Step.Where(x => x.StepId == step.StepId).FirstOrDefault();
            if(entity != null)
            {
                entity.StepName = step.StepName;
                Update(entity);
            }
        }
    }
}
