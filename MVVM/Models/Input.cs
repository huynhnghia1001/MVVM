﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Input
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
        public string Details { get; set; }

    }
}
