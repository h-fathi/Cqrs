using Hf.Cqrs.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hf.Cqrs.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IMediator _mediator;
        public ProjectController(ILogger<WeatherForecastController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _mediator.Send(new ProjectQuery());
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post()
        {
            var command = new CreateProjectCommand { Title = "Project" };
            var result = _mediator.Send(command);
            return Ok(result);
        }
    }
}
