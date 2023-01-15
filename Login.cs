using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC_Reg_User.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter Email ")]
        [Display(Name = "Email :")]
        [DataType(DataType.EmailAddress)]
        public string Uemail { get; set; }


        [Required(ErrorMessage = "Please Enter Password ")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
        public string Upass { get; set; }

    }
}