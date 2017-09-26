using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class InteractionBuilder : IFactory<Interaction>
    {
        private string Title;
        private Service service;
        private Topic Topic;
        
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

        public InteractionBuilder WithTopic(Topic topic)
        {
            this.Topic = topic;
            return this;
        }

        public Interaction Build()
        {
            return new Interaction(Title, service, Topic);
        }
    }
}
