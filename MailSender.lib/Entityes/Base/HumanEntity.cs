using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entityes.Base
{
    public abstract class HumanEntity : NameEntity
    {
        public virtual string Address { get; set; }
    }
}
