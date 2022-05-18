using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryReact.Services;
using LibraryReact.Models;
using System;
using Microsoft.AspNetCore.Http;

namespace LibraryReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly ILoginsServices _loginServices;

        public LoginsController(ILoginsServices loginServices)
        {
            _loginServices = loginServices;
        }
        [HttpPost("AdminLogin")]
        public Response AdminLogin(Admin login)
        {
            return _loginServices.AdminLogin(login);
        }

        [HttpPost("StudentLogin")]
        public Response StudentLogin(Member login)
        {
           return _loginServices.StudentLogin(login);  
        }


    }
}
