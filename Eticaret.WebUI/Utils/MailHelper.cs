using Eticaret.Core.Entities;
using System.Net;
using System.Net.Mail;


namespace Eticaret.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Contact contact)
        {
            SmtpClient smtpClient = new SmtpClient("mail.siteadi.com", 587);

        }
    }
}
