﻿using System;
using System.Collections.Generic;

namespace Project2API.Models.EF
{
    public partial class LoginTable
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string AccountPassword { get; set; } = null!;
        public string? Gender { get; set; }
    }
}
