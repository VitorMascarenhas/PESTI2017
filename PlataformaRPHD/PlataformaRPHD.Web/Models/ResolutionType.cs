using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.Models
{
    public class ResolutionType
    {
        public int Id { get; set; }

        public string Resolution { get; set; }

        public ResolutionType(int Id, string resolution)
        {
            this.Id = Id;
            this.Resolution = resolution;
        }
    }
}