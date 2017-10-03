using PlataformaRPHD.Domain.Entities.Entities;
using System;

namespace PlataformaRPHD.Web.ViewModels
{
    public class RequestWithSatisfactionSurveyViewModel
    {
        public int Id { get; set; }

        public User WhoRegistered { get; set; }

        public User Owner { get; set; }

        public DateTime TimeOfRegistration { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public string SourceComputer { get; set; }

        public string Contact { get; set; }

        public Origin Origin { get; set; }

        public Impact Impact { get; set; }

        public string answer1 { get; set; }

        public string answer2 { get; set; }

        public string suggestion { get; set; }

        public bool closed { get; set; }
    }
}