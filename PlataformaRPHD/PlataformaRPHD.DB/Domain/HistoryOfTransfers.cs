using System;

namespace PlataformaRPHD.DB.Domain
{
    public class HistoryOfTransfers
    {
        public int Id { get; set; }

        public int OfUserId { get; set; }

        public virtual User OfUser { get; set; }

        public int FromUserId { get; set; }

        public virtual User FromUser { get; set; }

        public int WhoUserId { get; set; }

        public virtual User WhoTransferred { get; set; }

        public string description { get; set; }

        public DateTime TimeResgisterred { get; set; }

        private HistoryOfTransfers() // EF
        {

        }

    }
}
