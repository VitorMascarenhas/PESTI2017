using System.Collections.Generic;

namespace PlataformaRPHD.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool HasWizard { get; private set; }

        public virtual CategoryViewModel ParentUpCategoryItem { get; set; }

        public virtual ICollection<CategoryViewModel> DownCategoryItems { get; private set; }
    }
}