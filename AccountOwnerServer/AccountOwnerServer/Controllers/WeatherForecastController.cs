﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AccountOwnerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message from the controller");
            _logger.LogDebug("Here is debug message from the controller");
            _logger.LogWarn("Here is warn message from the controller");
            _logger.LogError("Here is errormessage from the controller");

            return new string[] { "WeatherForecastController1", "WeatherForecastController2" };
        }
    }
}
