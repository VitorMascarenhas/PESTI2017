using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Step
    {
        #region Properties

        public int Id { get; set; }

        public byte[] ImageContent { get; set; }

        public string ImageType { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }
        
        [ForeignKey("ParentId")]
        public virtual Step ParentUpStepItem { get; private set; }

        public virtual ICollection<Step> DownStepItems { get; private set; }

        #endregion

        private Step() // For EF
        {
            this.DownStepItems = new HashSet<Step>();
        }

        public Step(Step parentItem, string description, byte[] image, string imageType) : this()
        {
            if (parentItem != null)
            {
                this.ParentUpStepItem = parentItem;

                parentItem.Add(this);
            }

            this.Description = description;
            this.ImageContent = image;
            this.ImageType = imageType;
        }
        
        public void Add(Step step)
        {
            this.DownStepItems.Add(step);
        }

        public bool HasDownStep()
        {
            return this.DownStepItems.Count > 0;
        }
    }
}
