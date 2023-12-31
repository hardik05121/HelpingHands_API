﻿using HelpingHands_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpingHands_Web.Models.VM
{
    public class CompanyCreateVM
    {
        public CompanyCreateVM()
        {
            Company = new CompanyDTO();
        }
        public CompanyDTO Company { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StateList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> CityList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> FirstCategoryList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> SecondCategoryList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> ThirdCategoryList { get; set; }

	}
}
