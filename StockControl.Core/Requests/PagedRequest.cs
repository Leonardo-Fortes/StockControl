﻿using StockControl.Core.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Core.Requests
{
    public abstract class PagedRequest : Request
    {
        public int PageSize { get; set; } = Configuration.DefaultPageSize;

        public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
    }
}
