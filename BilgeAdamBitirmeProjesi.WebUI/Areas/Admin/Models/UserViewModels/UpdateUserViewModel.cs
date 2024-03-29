﻿using BilgeAdamBitirmeProjesi.Common.Client.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdamBitirmeProjesi.WebUI.Areas.Admin.Models.UserViewModels
{
    public class UpdateUserViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Number { get; set; }

    }
}
