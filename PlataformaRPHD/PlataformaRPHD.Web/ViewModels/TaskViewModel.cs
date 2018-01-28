using PlataformaRPHD.Domain.Entities.Entities;
using System.Collections.Generic;

namespace PlataformaRPHD.Web.ViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }

        public virtual User Owner { get; set; }

        public string status { get; set; }
        
        public virtual InteractionViewModel InteractionViewModel { get; set; }

        public ICollection<Transfer> Transfers { get; set; }

        public ICollection<ChangeTaskStatus> HistoryChangeStatus { get; set; }
        
        public virtual Resolution resolution { get; set; }

        public bool close { get; set; }
    }
}