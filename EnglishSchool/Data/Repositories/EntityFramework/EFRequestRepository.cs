using EnglishSchool.Data.Entities;
using EnglishSchool.Services;
using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.EntityFramework
{
    public class EFRequestRepository
    {
        public void SendEmail(Request request, Config config)
        {
            try 
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(request.PersonName, request.PersonEmail));
                message.To.Add(MailboxAddress.Parse("santa_2005a@list.ru"));
                message.Subject = $"Заявка от на курс";
                message.Body = new BodyBuilder()
                {
                    HtmlBody = $"<div style=\"color: green;\">Заявка от { request.PersonName}, { request.PersonSurname}</div><div>Личные данные: </br>" +
                    $"Телефон {request.PersonPhone} Электронный адрес {request.PersonEmail} Выбранный курс {request.NameCourse}</br>" +
                    $"Ответы на ворпосы: </br> " +
                    $"Имя ребенка {request.ChildName} </br>" +
                    $"Возраст ребенка {request.ChildAge} </br>" +
                    $"Знает ли ребенок {request.ChildKnowledge} </br>" +
                    $"Увлечения ребенка {request.ChildHobby} </br>" +
                    $"Любимый персонаж {request.FavouriteCharacter} </br>" +
                    $"Что ребенок не любит {request.ThingsNotLike} </div>"
                }.ToMessageBody();

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.CheckCertificateRevocation = false;
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("fenix1234544@gmail.com", "Psychomantis1");
                    client.Send(message);

                    client.Disconnect(true);
                }
            }
            catch
            {
                throw new Exception("Email not sending");
            } 
        }

        //public void SendEmail(Request request, Config config)
        //{
        //        var sender = new SmtpSender(() => new SmtpClient("localhost")
        //        {
        //            EnableSsl = true,
        //            DeliveryMethod = SmtpDeliveryMethod.Network,
        //            Port = 44355
        //        });

        //        Email.DefaultSender = sender;

        //        var email = Email
        //            .From($"{request.PersonEmail}")
        //            .To("santa_2005a@list.ru")
        //            .Subject("Заявка от на курс")
        //            .Body($"Заявка от { request.PersonName}, { request.PersonSurname}Личные данные: Телефон {request.PersonPhone} Электронный адрес {request.PersonEmail} Выбранный курс {request.NameCourse} Ответы на ворпосы: Имя ребенка {request.ChildName} Возраст ребенка {request.ChildAge} Знает ли ребенок {request.ChildKnowledge} Увлечения ребенка {request.ChildHobby} Любимый персонаж {request.FavouriteCharacter} Что ребенок не любит {request.ThingsNotLike}")
        //            .SendAsync();
        //}
    }
}
