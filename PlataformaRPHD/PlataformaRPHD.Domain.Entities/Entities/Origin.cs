namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Origin
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private Origin() //For EF
        {
        }

        public Origin(string name)
        {
            this.Name = name;
        }
    }
}
