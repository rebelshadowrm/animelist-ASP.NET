﻿using BetterAnimeList.Classes;
using System.ComponentModel.DataAnnotations;

namespace BetterAnimeList.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [StringLength(24, MinimumLength = 3)]
        [RegularExpression(@"^(?=.{3,24}$)(?:[a-zA-Z\d]+(?:(?:\.|-|_)[a-zA-Z\d])*)+$", ErrorMessage = "Length 3-24, can contain _.- non repetitively")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Length must be {1} or greater.")]
        public string Password { get; set; }



    }
}