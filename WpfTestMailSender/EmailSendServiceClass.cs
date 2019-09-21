using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfTestMailSender;
using System.Net;
using System.Net.Mail;

namespace WpfTestMailSender
{
     class EmailSendServiceClass : WpfMailSender
     {

        private List<string> listStrMails;
        private  string strPassword;
       
        public   EmailSendServiceClass()
        {
            listStrMails = new List<string> { "SubochevIlya85@yandex.ru" };
            strPassword = passwordBox.Password;          
        }


        public void  SendMessages(string header, string body)
        {
            foreach (string mail in listStrMails)
            {
                using ( MailMessage mm = new MailMessage(VariableClass.fromEmail, mail))
                {
                    
                    mm.Subject = header;                           
                    mm.Body = body;
                    mm.IsBodyHtml = false;

                    using (SmtpClient sc = new SmtpClient(VariableClass.smtpEmail, VariableClass.smtpPort))
                    {

                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential(VariableClass.fromEmail, strPassword);
                        try
                        {
                            sc.Send(mm);
                            SendEndWindow sew = new SendEndWindow();
                            sew.Show();

                        }
                        catch (Exception ex)
                        {
                            WindowEr err = new WindowEr();
                            err.ErrorMessage("Невозможно отправить письмо" + ex.ToString());
                            err.Show();
                            
                        }
                    }
                }
            }            
        }

    }
}
