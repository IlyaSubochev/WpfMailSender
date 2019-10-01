using MailSender.lib.Entityes.Base;

namespace MailSender.lib.Entityes
{
    public class Email : BaseEntity
    { 
        public string Subject { get; set; }

        public string Body { get; set; }
        public string Name { get; internal set; }
        public string Address { get; internal set; }
    }
}
