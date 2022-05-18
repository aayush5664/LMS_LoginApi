using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryReact.Controllers;
using LibraryReact.Models;
using LibraryReact.Services;
namespace LibraryReact.Repositories
{
    public class LoginsServices : ILoginsServices
    {
        public static readonly List<Member> members = new List<Member>()
        {
            new Member {MemberID="M101",MemberFullName="Akash",MemberDOB="08/01/2000",MemberContactNo="8862003531",MemberEmail="ak@gmail.com",MemberFullAddress="Dwarka,Nashik",MemberPassword="123" },
            new Member { MemberID = "M102", MemberFullName = "Aayush",MemberDOB="29/11/1999",MemberContactNo="8177926762",MemberEmail="as@gmail.com",MemberFullAddress="satpur,Nashik",MemberPassword="123"},
        };
        public static readonly List<Admin> admins = new List<Admin>()
        {
            new Admin {AdminID="admin",AdminPassword="admin",AdminFullName="Akash"},
        };

        public Response AdminLogin(Admin login)
        {
            var log = admins.Where(x => x.AdminID.Equals(login.AdminID) &&
                      x.AdminPassword.Equals(login.AdminPassword)).FirstOrDefault();

            if (log == null)
            {
                return new Response { Status = "Invalid", Message = "Invalid User." };
            }
            else
                return new Response { Status = "Admin", Message = "Login Successfully" };
        }

        public Response StudentLogin(Member login)
        {
            var log = members.Where(x => x.MemberID.Equals(login.MemberID) &&
                         x.MemberPassword.Equals(login.MemberPassword)).FirstOrDefault();

            if (log == null)
            {
                return new Response { Status = "Invalid", Message = "Invalid User." };
            }
            else
                return new Response { Status = "Student", Message = "Login Successfully" };
        }
    }
}
