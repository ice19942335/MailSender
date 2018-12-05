using System.Linq;
using MailSender_Pattern_MVVM.DB_Elements;

namespace MailSender_Pattern_MVVM.Models
{
    public class SendersModel
    {
        private readonly EmailsSenderDataContext _emailSendersDataContext = new EmailsSenderDataContext();
        public IQueryable<EmailSender> SendersEmails => from q in _emailSendersDataContext.EmailSenders select q;
    }
}
