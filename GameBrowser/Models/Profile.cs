﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameBrowser.Models
{
    public class Profile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int No { get; set; }

        [Display(Name = "Record")]
        [Required]
        [Range(1, 5000, ErrorMessage = "Invalid value")]
        public int Record { get; set; }

        [Display(Name = "Nickname")]
        [Required]
        [StringLength (15, MinimumLength = 3, ErrorMessage = "Invalid value")]
        public string NickName { get; set; }

        [Display(Name = "Score")]
        [Required]

        public int Score { get; set; }

    }

}
