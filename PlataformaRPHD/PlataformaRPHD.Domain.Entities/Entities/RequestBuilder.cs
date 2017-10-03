namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class RequestBuilder : IFactory<Request>
    {
        private User WhoRegistered;
        private User Owner;
        private string Title;
        private string Description { get; set; }
        private string sourceComputer;
        private string contact { get; set; }
        private Origin origin { get; set; }
        private Category Category { get; set; }
        private Impact Impact { get; set; }

        public RequestBuilder()
        {
        }
        
        public RequestBuilder WithWhoRegistered(User user)
        {
            this.WhoRegistered = user;
            return this;
        }

        public RequestBuilder WithOwner(User user)
        {
            this.Owner = user;
            return this;
        }

        public RequestBuilder WithTitle(string title)
        {
            this.Title = title;
            return this;
        }
        
        public RequestBuilder WithDescription(string description)
        {
            this.Description = description;
            return this;
        }
        
        public RequestBuilder WithComputer(string computer)
        {
            this.sourceComputer = computer;
            return this;
        }

        public RequestBuilder WithContact(string contact)
        {
            this.contact = contact;
            return this;
        }

        public RequestBuilder WithOrigin(Origin origin)
        {
            this.origin = origin;
            return this;
        }
        
        public RequestBuilder WithImpact(Impact impact)
        {
            this.Impact = impact;
            return this;
        }

        public RequestBuilder WithCategory(Category category)
        {
            this.Category = category;
            return this;
        }
        
        public Request Build()
        {
            return new Request(WhoRegistered, Owner, Title, Description, Category, sourceComputer, contact, origin, Impact);
        }
    }
}
