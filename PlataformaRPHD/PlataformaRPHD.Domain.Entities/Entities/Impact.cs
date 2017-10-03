namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class Impact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        private Impact() //for EF
        {
        }

        public Impact(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
