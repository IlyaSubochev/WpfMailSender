using MailSender.lib.Entityes.Base;
using System.Collections.Generic;

namespace MailSender.lib.Entityes
{
    public class RecipientsList : NameEntity
    { 
        public ICollection<Recipient> Recipients { get; set; }
    }
}
