using BugTracker.Application.Contracts.Infrastructure;
using BugTracker.Application.Models;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Infrastructure.Mail
{
    public class EmailSender : IEmailSender
    {
        private EmailSettings EmailSettings { get; }
        public EmailSender(IOptions<EmailSettings> emailSettings) // options passed in from appsettings file
        {
            EmailSettings = emailSettings.Value;
        }
            

        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(EmailSettings.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email = EmailSettings.FromAddress,
                Name = EmailSettings.FromName
            };

            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
            var response = await client.SendEmailAsync(message);

            // if either OK or|| Accepted its true, if neither its false
            return response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Accepted;

        }
    }
}
