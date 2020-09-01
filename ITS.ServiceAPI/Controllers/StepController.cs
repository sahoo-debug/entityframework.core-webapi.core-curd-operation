using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITS.Core.DBEntity;
using ITS.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITS.ServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepController : ControllerBase
    {
        private readonly IStepService _stepService;
        public StepController(IStepService stepService)
        {
            _stepService = stepService;
        }


        [Route("getallsteps")]
        [HttpGet]
        public IList<Step> Getallsteps()
        {
            return _stepService.GetAllSteps();
        }

        [Route("getstep/{id}")]
        [HttpGet]
        public Step GetStep(long id)
        {
            return _stepService.GetStep(id);
        }

        [Route("addstep")]
        [HttpPost]
        public IList<Step> AddStep()
        {
            return _stepService.AddStep();
        }

        [Route("removestep/{id}")]
        [HttpDelete]
        public IList<Step> RemoveStep(long id)
        {
            return _stepService.ArchiveStep(id);
        }

        [Route("updatestep")]
        [HttpGet]
        public bool UpdateStep()
        {
            var step = new Step { StepId = 2, StepName = "Step2updated" };
            _stepService.UpdateStep(step);
            return true;
        }

    }
}
