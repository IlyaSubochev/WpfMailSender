using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.InMemory
{
    public class InMemoryRecipientDataProvider : IRecipientsDataProvider
    {
        public readonly List<Recepient> _Recipients = new List<Recepient>();
        public int Create(Recepient recipient)
        {
            if (_Recipients.Contains(recipient)) return recipient.Id;
            recipient.Id = _Recipients.Count == 0 ? 1 : _Recipients.Max(r => r.Id) + 1;
            _Recipients.Add(recipient);
            return recipient.Id;
        }

        public IEnumerable<Recepient> GetAll() => _Recipients;
        

        public void SaveChanges()
        {
           
        }
    }
}
