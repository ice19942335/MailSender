using System.Linq;
using MailSender_Pattern_MVVM.DB_Elements;

namespace MailSender_Pattern_MVVM.Models
{
    public class RecipientsModel
    {
        private readonly EmailRecipientDataContext _emailRecipientDataContext = new EmailRecipientDataContext();
        public IQueryable<EmailRecipient> Recipients => from q in _emailRecipientDataContext.EmailRecipients select q;
    }
}
