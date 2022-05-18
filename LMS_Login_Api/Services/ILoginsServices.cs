using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using LibraryReact.Controllers;
using LibraryReact.Models;

namespace LibraryReact.Services
{
    public interface ILoginsServices
    {
        public Response AdminLogin(Admin login);
        public Response StudentLogin(Member login);



    }
}