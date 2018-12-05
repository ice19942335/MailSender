using System;
using System.Linq;
using System.Windows;
using MailSender_Pattern_MVVM.DB_Elements;

namespace MailSender_Pattern_MVVM.Service
{
    public class EmailSenderDataAccessService : IEmailSenderDataAccessService
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private readonly EmailsSenderDataContext _emailSendersDataContext;
        /// <summary>
        /// Constructor without parametrs
        /// </summary>
        public EmailSenderDataAccessService()
        {
            _emailSendersDataContext = new EmailsSenderDataContext();
        }
        /// <summary>
        /// Creating new record EmailSender in DB
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int CreateEmailSender(EmailSender email)
        {
            try
            {
                _emailSendersDataContext.EmailSenders.InsertOnSubmit(email);
                _emailSendersDataContext.SubmitChanges();
                return email.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        /// <summary>
        /// Deleting existing record EmailSender from DB
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool DeleteEmailSender(EmailSender email)
        {
            try
            {
                _emailSendersDataContext.EmailSenders.Attach(email);
                _emailSendersDataContext.EmailSenders.DeleteOnSubmit(email);
                _emailSendersDataContext.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        /// <summary>
        /// Editig existing record EmailSender in DB
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EditEmailSender(EmailSender email)
        {
            try
            {
                EmailSender nEmail = _emailSendersDataContext.EmailSenders.Single(e => e.Id == email.Id);
                nEmail.Email = email.Email;
                nEmail.Hash = email.Hash;
                _emailSendersDataContext.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
