using PlataformaRPHD.Domain.Entities.Entities;
using System.Web;

namespace PlataformaRPHD.Web.ViewModels
{
    public class WizardViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public User CreateBy { get; set; }

        public string Step1 { get; set; }

        public string Step2 { get; set; }

        public string Step3 { get; set; }

        public bool Approved { get; set; }
    }
}