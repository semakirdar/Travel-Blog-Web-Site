﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Web_Sitesi.Models.Siniflar
{
    public class BlogYorum
    {   //koleksiyon olarak bir view içinden birden fazla değer çekebilicem
        public IEnumerable<Blog> Deger1 { get; set; }
     
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}