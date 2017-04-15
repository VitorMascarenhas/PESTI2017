namespace PlataformaRPHD.DB.Domain
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        private Category() // EF
        {
        }

        public Category(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
