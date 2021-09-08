using System;
using System.ComponentModel.DataAnnotations;

namespace MyIdentityApp.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
