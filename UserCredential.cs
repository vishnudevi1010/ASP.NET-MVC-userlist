using System;
using System.Collections.Generic;

namespace entityframe.Models.entities
{
    public partial class UserCredential
    {
        public int Id { get; set; }
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
