﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HelpingHands_Web.Models.DTO
{
    public class AmenityCreateDTO
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("amenity name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "The field must be between 3 and 15 characters.")]
        public string AmenityName { get; set; }

        [DisplayName("firstcategory name")]
        [Required]
        public int FirstCategoryId { get; set; }

        public bool IsActive { get; set; }
		public bool IsCheked { get; set; }
	}
}
