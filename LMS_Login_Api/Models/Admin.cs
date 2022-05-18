using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace LibraryReact.Models
{

    public class Admin
    {
        [Key]
        public string AdminID { get; set; }
        public string AdminPassword { get; set; }
        public string AdminFullName { get; set; }
    }
}
