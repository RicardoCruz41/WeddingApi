using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using WeddingApi.Controllers.Helper;

namespace WeddingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AttendanceController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("SendAttendanceConfirmation")]
        public void SendAttendanceConfirmation(AttendanceConfirmation attendanceConfirmation)
        {
            var baseSubject = EmailTemplates.GetBaseSubject(attendanceConfirmation.Name, attendanceConfirmation.Language);
            var confirmationForHost = $" com {attendanceConfirmation.Name} para o nosso casamento!";
               
            if (attendanceConfirmation.IsAttending)
            {
                if (!string.IsNullOrEmpty(attendanceConfirmation.Restrictions))
                    confirmationForHost += $"\n\nEste\\a tem as seguintes restrições alimentares:\n\n {attendanceConfirmation.Restrictions}";

                if (!string.IsNullOrEmpty(attendanceConfirmation.Message))
                    confirmationForHost += $"\n\nEste\\a deixou-nos a seguinte mensagem :\n\n {attendanceConfirmation.Message}";

                var isAttendingBody = EmailTemplates.GetIsAttendingBody(attendanceConfirmation.Name, attendanceConfirmation.Language);

                SendEmail(attendanceConfirmation.Email, baseSubject, isAttendingBody);
                SendEmail(_configuration["EmailSettings:SenderEmail"].ToString(), $"{attendanceConfirmation.Name} estará presente no nosso casamento!", $"Contamos {confirmationForHost}");
            }
            else
            {
                if (!string.IsNullOrEmpty(attendanceConfirmation.Message))
                    confirmationForHost += $"\n\nEste\\a deixou-nos a seguinte mensagem :\n\n {attendanceConfirmation.Message}";
                
                var isNotAttendingBody = EmailTemplates.GetIsNotAttendingBody(attendanceConfirmation.Name, attendanceConfirmation.Language);

                SendEmail(attendanceConfirmation.Email, baseSubject, isNotAttendingBody);
                SendEmail(_configuration["EmailSettings:SenderEmail"].ToString(), $"{attendanceConfirmation.Name} não estará presente no nosso casamento.", $"Não contamos {confirmationForHost}");
            }
        }

        private void SendEmail(string toEmail, string subject, string body)
        {
            var smtpClient = new SmtpClient(_configuration["EmailSettings:SMTPServer"])
            {
                Port = int.Parse(_configuration["EmailSettings:SMTPPort"]),
                Credentials = new NetworkCredential(
                    _configuration["EmailSettings:SenderEmail"],
                    _configuration["EmailSettings:SenderPassword"]),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_configuration["EmailSettings:SenderEmail"], "Ricardo & Carolina"),
                Subject = subject,
                Body = body,
                IsBodyHtml = false,
            };

            mailMessage.To.Add(toEmail);

            smtpClient.Send(mailMessage);
        }
    }
}