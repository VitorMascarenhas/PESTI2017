using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class RequestBuilder : IFactory<Request>
    {
        private User WhoRegistered;
        private User Owner;
        private string Title;
        private string Description { get; set; }
        private ICollection<Interaction> Interactions;
        private string sourceComputer;
        private ICollection<Attachment> attachments { get; set; }
        private string contact { get; set; }
        private string origin { get; set; }

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
        
        public RequestBuilder WithInteractions(Interaction interaction)
        {
            this.Interactions.Add(interaction);
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

        public RequestBuilder WithOrigin(string origin)
        {
            this.origin = origin;
            return this;
        }

        public RequestBuilder WithAttachment(Attachment attachment)
        {
            this.attachments.Add(attachment);
            return this;
        }
        
        public Request Build()
        {
            return new Request(WhoRegistered, Owner, Title, Description, Interactions, attachments, sourceComputer, contact, origin);
        }
    }
}
