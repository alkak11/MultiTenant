﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiTenant.Models
{
    public class RetailerViewModel: BaseViewModel
    {
        public string CalendarSales { get; set; }
        public string FiscalSales { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}