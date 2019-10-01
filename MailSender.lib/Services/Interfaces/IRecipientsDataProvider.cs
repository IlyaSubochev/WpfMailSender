using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsDataProvider : IDataProvider<Recipient> { }
}
