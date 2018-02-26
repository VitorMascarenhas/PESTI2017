using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.Models
{
    public class Status
    {
        public string Name { get; set; }

        public Status(string status)
        {
            this.Name = status;
        }
    }
}