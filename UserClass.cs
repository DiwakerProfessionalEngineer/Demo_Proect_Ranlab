using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Reg_User.Models
{
    public class UserClass
    {

        [Required(ErrorMessage ="Enter Username ")]
        [Display(Name ="Name :")]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="Username langth Must be max 7 & min 3")]
        public string Uname { get; set; }

        [Required(ErrorMessage ="Please Enter Email !")]
        [Display(Name ="Email :")]
        public string Uemail { get; set; }


        [Required(ErrorMessage = "Please Enter password !")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
         public string Upass { get; set; }


        [Required(ErrorMessage = "Please Enter Repassword !")]
        [Display(Name = "Re-Password :")]
        [DataType(DataType.Password)]
        [Compare("Upass")]
        public string Repass { get; set; }


        [Required(ErrorMessage = "Select the Gender !")]
        [Display(Name = "Gender :")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Upload Profile Image !")]
        [Display(Name = "Photo  :")]
        public string Uimg { get; set; }
         
    }
}