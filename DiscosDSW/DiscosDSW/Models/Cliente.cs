﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiscosDSW.Models
{
    public class Cliente
    {
        public override string ToString()
        {
            return this.Nombre + "|" + this.Email + "|" + this.Password;
        }
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}