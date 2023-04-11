﻿using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public partial class User
    {
        public int UserId { get; set; }
        public int? RoleId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual Role? Role { get; set; }
    }
}
