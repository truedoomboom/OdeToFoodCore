﻿using OdeToFoodCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodCore.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
