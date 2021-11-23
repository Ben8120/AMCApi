using System;
using System.Collections.Generic;

#nullable disable

namespace AMCApi.Models
{
    public partial class UserCredential
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsCleaner { get; set; }
    }
}
