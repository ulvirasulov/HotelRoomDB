﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Hotels Hotels { get; set; }
    }
}
