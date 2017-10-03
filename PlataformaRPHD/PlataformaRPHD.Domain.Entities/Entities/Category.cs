using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Category
    {
        #region Properties

        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool HasWizard { get; private set; }
        
        [ForeignKey("ParentId")]
        public virtual Category ParentUpCategoryItem { get; set; }

        public virtual ICollection<Category> DownCategoryItems { get; private set; }

        #endregion

        private Category()
        {
            this.DownCategoryItems = new HashSet<Category>();
            this.HasWizard = false;
        }

        public Category(Category parentItem, string name, string description) : this()
        {
            if (parentItem != null)
            {
                this.ParentUpCategoryItem = parentItem;

                parentItem.Add(this);
            }

            this.Name = name;
            this.Description = description;
        }
        
        public bool WithWizard()
        {
            this.HasWizard = true;

            return this.HasWizard;
        }

        public bool WithoutWizard()
        {
            this.HasWizard = false;

            return this.HasWizard;
        }

        public void Add(Category category)
        {
            this.DownCategoryItems.Add(category);
        }

        public bool HasDownCategory()
        {
            return this.DownCategoryItems.Count > 0;
        }
    }
}
