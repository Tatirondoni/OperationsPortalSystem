using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationsPortal.Api.Models
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}