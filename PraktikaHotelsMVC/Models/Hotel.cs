﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraktikaHotelsMVC.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Services { get; set; }
        public string PhotoFile { get; set; }
        public string Aadress { get; set; }
    }
}