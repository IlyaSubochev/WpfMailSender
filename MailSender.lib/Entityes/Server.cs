using MailSender.lib.Entityes.Base;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entityes
{
    public class Server :NameEntity
    {
        public string Host { get; set; }

        public int Port { get; set; } = 25;

        public bool UseSSL { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Description { get; set; }
    }
}
