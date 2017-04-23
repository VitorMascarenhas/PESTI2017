using System.Collections.Generic;

namespace PlataformaRPHD.DB.Domain
{
    public class User
    {
        public int Id { get; set; }

        public UserName Name { get; set; }

        public string mechanographicNumber { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public int UserStatusId { get; set; }

        public virtual UserStatus userStatus { get; set; }

        private User() // EF
        {
            this.Tasks = new HashSet<Task>();
            this.Requests = new HashSet<Request>();
        }

        public User(UserName userName)
        {
            this.Name = userName;
        }
    }
}
