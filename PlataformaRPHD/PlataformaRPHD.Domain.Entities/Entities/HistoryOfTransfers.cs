using System;
using System.Collections.Generic;

namespace PlataformaRPHD.Domain.Entities.Entities
{
    public class HistoryOfTransfers
    {
        public int Id { get; set; }

        public virtual Dictionary<Transfer, DateTime> Transfers { get; set; }

        public HistoryOfTransfers() // EF
        {
            this.Transfers = new Dictionary<Transfer, DateTime>();
        }

        public void AddTransfer(Transfer Transfer)
        {
            if (Transfer == null)
            {
                throw new ArgumentNullException();
            }
            this.Transfers.Add(Transfer, new DateTime());
        }
    }
}
