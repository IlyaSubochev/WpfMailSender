using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entityes.Base
{
    public class Recipient : HumanEntity 
    
    {
        public override string Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
            }
        }
    }
}
