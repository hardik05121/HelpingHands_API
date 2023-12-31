﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HelpingHands_Web.Models.DTO
{
    public class CompanyUpdateDTO
    {
        public int Id { get; set; }


        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [DisplayName("Company Logo")]
        public string CompanyLogo { get; set; }
        public int FirstCategoryId { get; set; }
        public int? SecondCategoryId { get; set; }
        public int? ThirdCategoryId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string? Certificate { get; set; }

        public bool? IsDelete { get; set; }

        public bool IsActive { get; set; }

        public string? WhatsApp { get; set; }


        public string? InstagramId { get; set; }

        public string? Facebook { get; set; }

        public string? Website { get; set; }

        public string? Twitter { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }


        [DisplayName("Year Of Establishment")]
        public DateTime EstablishDate { get; set; }


        //[ForeignKey("User")]
        //public int UserId { get; set; }
        //[ValidateNever]
        //public ApplicationUser ApplicationUser { get; set; }
    }
}
