﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientCitas.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
