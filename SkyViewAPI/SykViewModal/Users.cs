using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SykViewModal
{
    public class Users
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }
        public bool isAdmin { get; set; }
        public bool superAdmin { get; set; }
        public DateTime createdOn { get; set; }
        public int createdBy { get; set; }
        public DateTime? updatedOn { get; set; }
        public int updatedBy { get; set; }

    }
}
