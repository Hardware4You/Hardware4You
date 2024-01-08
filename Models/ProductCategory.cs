﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hardware4You.Models
{
    public class ProductCategory
    {
        public long Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
