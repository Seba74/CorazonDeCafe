﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorazonDeCafeStockManager.App.Vars
{
    public static class SessionManager
    {
        public static string? Name { get; set; }
        public static int? RoleId { get; set; }
        public static string? Username { get; set; }
        public static bool? IsLoggedIn { get; set; }

        public static void Logout()
        {
            Name = null;
            RoleId = null;
            Username = null;
            IsLoggedIn = false;
        }
    }
}
