﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TateFoodIt.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}