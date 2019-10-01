using MailSender.lib.Entityes.Base;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.InMemory
{
    public class InMemoryRecipientDataProvider : InDataProvider<Recipient>, IRecipientsDataProvider
    {
       
        public override void Edit(int id, Recipient item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;
            db_item.Name = item.Name;
            db_item.Address = item.Address;
        }

       
    }

    

    


}
