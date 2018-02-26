using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.Models
{
    public class UserModel
    {
        public string SamAccountName { get; set; }

        public string Name { get; set; }

        public UserModel(string samAccountName, string name)
        {
            this.SamAccountName = samAccountName;
            this.Name = name;
        }
    }
}