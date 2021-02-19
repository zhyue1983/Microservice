using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.BLL;
using UserService.DAL.Entity;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IBaseBLL _baseBLL;
        public WeatherForecastController(IBaseBLL baseBLL)
        {

            _baseBLL = baseBLL;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public BaseResponse Get()
        {
            List<User> list = _baseBLL.GetList<User>();

            User user = new User() { Name = "xue", Mobile = "123", Password = "1234", CreateTime = new DateTime(2021, 2, 19), UpdateTime = new DateTime(2021, 2, 19), Status = 1 };
            int res = _baseBLL.Insert(user);
            return BaseResponse.Success(list);
        }




    }
}
