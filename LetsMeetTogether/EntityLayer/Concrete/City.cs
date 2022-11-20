﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {

        public int CityID { get; set; }
        public string Name { get; set; }
        //public string ImageUrl { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
