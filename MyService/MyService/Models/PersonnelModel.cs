using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyService.Models
{
    public class PersonnelModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}