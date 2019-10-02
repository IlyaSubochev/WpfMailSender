using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public static class VariablesClass
    {
        public static Dictionary<string, string> Senders
        {
            get { return dicSenders; }
        }
        private static Dictionary<string, string> dicSenders = new
        Dictionary<string, string>()
        {
            { "ivanov@yandex.ru" , PasswordClass . getPassword ( "1234l;i" ) },
            { "petrov@mail.ru" , PasswordClass . getPassword ( ";liq34tjk" ) },
             { "sidorov@gmail.ru" , PasswordClass . getPassword ( "ii1234l;i" ) }
        };
    }
    public static class PasswordClass
    {
        public static string getPassword(string p_sPassw)
        {
            string password = "";
            foreach (char a in p_sPassw)
            {
                char ch = a;
                ch--;
                password += ch;
            }
            return password;
        }
       
        public static string getCodPassword(string p_sPassword)
        {
            string sCode = "";
            foreach (char a in p_sPassword)
            {
                char ch = a;
                ch++;
                sCode += ch;
            }
            return sCode;
        }
    }
}
