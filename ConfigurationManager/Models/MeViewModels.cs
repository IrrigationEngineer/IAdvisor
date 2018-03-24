﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConfigurationManager.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string UserName { get; set; }
        public string Hometown { get; set; }
    }
}