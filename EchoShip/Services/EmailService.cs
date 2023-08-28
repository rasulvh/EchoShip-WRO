using EchoShip.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace EchoShip.Services
{
    public class EmailService : IEmailService
    {
        public void Send(string to, string subject, string html, string from = null)
        {
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("rasulvh@code.edu.az"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = "Email Confirmation";
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("rasulvh@code.edu.az", "isxmeulkiwgdbejg");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
