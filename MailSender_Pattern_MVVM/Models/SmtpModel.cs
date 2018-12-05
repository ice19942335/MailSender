using System.Linq;
using MailSender_Pattern_MVVM.DB_Elements;

namespace MailSender_Pattern_MVVM.Models
{
    public class SmtpModel
    {
        private readonly EmailSmtpDataContext _emailSmtpDataContext = new EmailSmtpDataContext();
        public IQueryable<EmailSmtp> SendersSmtp => from q in _emailSmtpDataContext.EmailSmtps select q;
    }
}
