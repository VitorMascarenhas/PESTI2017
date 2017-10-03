using System.ComponentModel.DataAnnotations;

namespace PlataformaRPHD.Web.ViewModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}