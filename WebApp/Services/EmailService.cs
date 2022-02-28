using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebApp.Settings;

namespace WebApp.Services
{
    public class EmailService : IEmailService
    {
        private readonly IOptions<SmtpSettings> smptSetting;

        public EmailService(IOptions<SmtpSettings> smtpSetting)
        {
            this.smptSetting = smtpSetting;
        }
        public async Task SendAsync(string from, string to, string subject, string body)
        {
            var message = new MailMessage(from,
                      to,
                      subject,
                      body);

            using (var emailClient = new SmtpClient(smptSetting.Value.Host, smptSetting.Value.Port))
            {
                emailClient.Credentials = new NetworkCredential(smptSetting.Value.User, smptSetting.Value.Password);
                emailClient.EnableSsl = true;
                await emailClient.SendMailAsync(message);
            };
        }
    }
}
