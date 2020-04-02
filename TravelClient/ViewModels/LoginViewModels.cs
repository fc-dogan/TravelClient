using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TravelClient.Providers;

namespace TravelClient.ViewModels
{
  public class LoginViewModel
  {
      [Required]
      [Display(Name ="Username")]
      public string Username { get; set; }
  
      [Required]
      [DataType(DataType.Password)]
      [Display(Name = "Password")]
      public string Password { get; set; }
  
      [Display(Name = "Remember me?")]
      public bool RememberMe { get; set; }
  }
}