using PlataformaRPHD.Domain.Entities.Entities;

namespace PlataformaRPHD.Web.ViewModels
{
    public class WizardViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public StepViewModel Step1 { get; set; }

        public StepViewModel Step2 { get; set; }

        public StepViewModel Step3 { get; set; }

        public bool Approved { get; set; }
    }
}