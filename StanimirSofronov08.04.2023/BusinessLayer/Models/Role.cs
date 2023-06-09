﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
