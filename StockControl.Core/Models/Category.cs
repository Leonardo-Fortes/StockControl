﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Core.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = null!;
    }
}
