using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using OrderService.BLL;
using OrderService.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IBaseBLL _baseBLL;
        public WeatherForecastController(IBaseBLL baseBLL)
        {

            _baseBLL = baseBLL;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public BaseResponse Get()
        {
            List<Order> list = _baseBLL.GetList<Order>();


            return BaseResponse.Success(list);
        }
    }
}
