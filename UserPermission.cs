﻿using System;
using System.Collections.Generic;

namespace entityframe.Models.entities
{
    public partial class UserPermission
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }
    }
}
