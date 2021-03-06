﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seaonsonedintheabysstruck.ViewModels
{
    public class AddMenuViewModel
    {
        [Required]
        [Display(Name = "Menu Item")]
        public string MenuItem { get; set; }

        [Required]
        [Display(Name = "Menu Price")]
        public int Price { get; set; }

        public int Id { get; set; }
    }
}
