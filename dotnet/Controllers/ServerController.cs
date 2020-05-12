using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Linq;

namespace RainApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        // private readonly ILogger<WeatherForecastController> _logger;
        
        // public ServerController(ILogger<ServerController> logger)
        // {
        //     _logger = logger;
        // }
        
        [HttpGet]
        public DataServer Get() 
        {
            var data = new DataServer();

            var osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

            data.Date = DateTime.Now;
            data.Hostname = System.Net.Dns.GetHostName();
            data.OS = osNameAndVersion;

            return data;
        }

    }
}