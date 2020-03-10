using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using MimeKit;
using HR_App.Data;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace HR_App.Scheduler
{
public class ReminderService : IHostedService
{
        private readonly IServiceScopeFactory _scopeFactory;
        public ReminderService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Start");
            using (var scope = _scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var x = from i in context.reminders select i;
                foreach (var i in x)
                {
                    if (i.events.Month == DateTime.Now.Month && i.events.AddDays(-3).Day == DateTime.Now.AddDays(-3).Day)
                    {
                        Task.Run(TaskRoutine, cancellationToken);
                    }
                    else
                    {
                        Task.Run(Dont, cancellationToken);
                    }
                }
            }
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Sync Task stopped");
            return Task.CompletedTask;
        }

        public Task TaskRoutine()
        {
            
            while (true)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var x = from i in context.employees select i;
                var evt = (from i in context.reminders where i.events.AddDays(-3).Day == DateTime.Now.AddDays(-3).Day select i).FirstOrDefault(); 
                foreach (var i in x)
                {
                var message = new MimeMessage();
                message.To.Add(new MailboxAddress(i.name, i.email));
                message.From.Add(new MailboxAddress("HR","HRAPP@hr.com"));
                message.Subject = "Selamat Hari "+evt.name;
                message.Body = new TextPart("plain")
                {
                    Text = "Dalam memperingati Hari "+evt.name+" maka perusahaan akan di Liburkan pada tanggal "+evt.events
                };
                using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
                {
                    emailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    emailClient.Connect("smtp.mailtrap.io", 587, false);
                    emailClient.Authenticate("c2dd5c9169381f", "8d33632650e24e");
                    emailClient.Send(message);
                    emailClient.Disconnect(true);
                }
                }
                }
                //Wait 10 minutes till next execution
                DateTime nextStop = DateTime.Now.AddDays(1);
                var timeToWait = nextStop - DateTime.Now;
                var millisToWait = timeToWait.TotalMilliseconds;
                Thread.Sleep((int)millisToWait);
            }
        }

        public Task Dont()
        {
            
            while (true)
            {
                Console.WriteLine("NOT HAD REMINDERS");
                //Wait 10 minutes till next execution
                DateTime nextStop = DateTime.Now.AddDays(1);
                var timeToWait = nextStop - DateTime.Now;
                var millisToWait = timeToWait.TotalMilliseconds;
                Thread.Sleep((int)millisToWait);
            }
        }
    }
}