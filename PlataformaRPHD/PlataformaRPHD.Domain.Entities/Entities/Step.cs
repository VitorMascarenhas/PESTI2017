using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Step
    {
        #region Properties

        public int Id { get; set; }

        public byte[] Imagem { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }
        
        [ForeignKey("ParentId")]
        public virtual Step ParentUpStepItem { get; set; }

        public virtual ICollection<Step> DownStepItems { get; private set; }

        #endregion

        private Step() // For EF
        {
            this.DownStepItems = new HashSet<Step>();
        }

        public Step(Step parentItem, string description, byte[] image) : this()
        {
            if (parentItem != null)
            {
                this.ParentUpStepItem = parentItem;

                parentItem.Add(this);
            }

            this.Description = description;
            this.Imagem = image;
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
