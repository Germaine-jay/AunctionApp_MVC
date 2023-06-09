﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AunctionApp.BLL.Models
{
    public class AuctionVM
    {
        public int? Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ActualAmount { get; set; }

        [RegularExpression(@"^.*\.(jpeg|jpg|png)$", ErrorMessage = "Only .jpeg, .jpg, and .png files are allowed.")]
        public IFormFile ProductImagePath { get; set; }
        public string? IsSold { get; set; }
    }
}
