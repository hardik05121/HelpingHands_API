﻿using HelpingHands_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpingHands_Web.Models.VM
{
    public class CompanyXAmenityVM
    {
        public CompanyXAmenityVM()
        {
            CompanyXAmenity = new CompanyXAmenityCreateDTO();
            Company = new CompanyCreateDTO();
        }

        public CompanyXAmenityCreateDTO CompanyXAmenity { get; set; }

        public CompanyCreateDTO Company { get; set; }

        [ValidateNever]
        public List<CompanyXAmenityCreateDTO> CompanyXAmenitylist { get; set; }

        [ValidateNever]
        public List<AmenityDTO> Amenitylist { get; set; }
    }
}
