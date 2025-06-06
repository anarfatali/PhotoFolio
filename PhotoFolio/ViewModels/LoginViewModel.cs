﻿using System.ComponentModel.DataAnnotations;

namespace PhotoFolio.ViewModels;

public class LoginViewModel
{       
    [Required(ErrorMessage = "Login can not be empty.")]
    public string Login { get; set; }    

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = "";

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }
}
