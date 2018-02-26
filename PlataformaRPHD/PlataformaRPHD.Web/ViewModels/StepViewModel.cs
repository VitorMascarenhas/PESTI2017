using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Web.ViewModels
{
    public class StepViewModel
    {
        public int Id { get; set; }

        public byte[] ImageContent { get; set; }

        public string ImageType { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }

        public Step ParentUpStepItem { get; set; }

        public ICollection<Step> DownStepItems { get; private set; }
    }
}