﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using HelpingHands_API.Models.DTO;

namespace HelpingHands_API.Models
{
    public class Enquiry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        [ValidateNever]
        public Company Company { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }


        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("User Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("User Phone Number")]
        public int PhoneNumber { get; set; }
        [Required]
        [DisplayName("Enquiry Title")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Brif Description Of Your Enquiry")]
        public string Description { get; set; }

        


    }
}
