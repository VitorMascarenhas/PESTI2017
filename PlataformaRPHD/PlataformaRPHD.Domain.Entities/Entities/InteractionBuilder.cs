namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class InteractionBuilder : IFactory<Interaction>
    {
        private string Title;
        private Service service;

        public InteractionBuilder WithTitle(string title)
        {
            this.Title = title;
            return this;
        }

        public InteractionBuilder WithService(Service service)
        {
            this.service = service;
            return this;
        }
        
        public Interaction Build()
        {
            return new Interaction(Title, service);
        }
    }
}
