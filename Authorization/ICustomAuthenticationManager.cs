﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization
{
    public interface ICustomAuthenticationManager
    {
        string Authenticate(string username, string password);
        IDictionary<string, string> Tokens { get; set; }

    }
}
