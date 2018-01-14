using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [DisplayName("Nome do utilizador")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Palavra-Passe")]
        public string Password { get; set; }
    }
}