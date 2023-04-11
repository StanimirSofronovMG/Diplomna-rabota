using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class User
    {
        public User()
        {
            TableShifts = new HashSet<TableShift>();
            UserVacations = new HashSet<UserVacation>();
        }

        public int UserId { get; set; }

        public int? RoleId { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public virtual Role? Role { get; set; }

        public virtual ICollection<TableShift> TableShifts { get; set; }

        public virtual ICollection<UserVacation> UserVacations { get; set; }
    }
}
