namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Category : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        private Category()
        {
        }

        public Category(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
