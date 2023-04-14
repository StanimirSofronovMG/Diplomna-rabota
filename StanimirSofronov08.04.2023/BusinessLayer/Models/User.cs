using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    public partial class User
    {
        public User()
        {
            TableShifts = new HashSet<TableShift>();
            UserVacations = new HashSet<UserVacation>();
        }
        [Key]
        public int UserId { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<TableShift> TableShifts { get; set; }

        public virtual ICollection<UserVacation> UserVacations { get; set; }
    }
}
