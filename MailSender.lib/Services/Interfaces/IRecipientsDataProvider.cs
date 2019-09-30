using MailSender.lib.Data.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsDataProvider
    {
        IEnumerable<Recepient> GetAll();

        int Create(Recepient recipient);

        void SaveChanges();
    }
}
