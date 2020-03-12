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
public class BhirtdayService : IHostedService
{
        private readonly IServiceScopeFactory _scopeFactory;
        public BhirtdayService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Start");
            // using (var scope = _scopeFactory.CreateScope())
            // {
            //     var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            //     var x = (from i in context.employees select i).FirstOrDefault();
            //         if (x.bhirtdate.Month == DateTime.Now.Month && x.bhirtdate.Day == DateTime.Now.Day)
            //         {
            //             Task.Run(TaskRoutine, cancellationToken);
            //         }
            //         else
            //         {
            //             Task.Run(Dont, cancellationToken);
            //         }
            // }
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
                var x = from i in context.employees where (i.bhirtdate.Month == DateTime.Now.Month && i.bhirtdate.Day == DateTime.Now.Day) select i;
                foreach (var i in x)
                {
                var message = new MimeMessage();
                message.To.Add(new MailboxAddress(i.name, i.email));
                message.From.Add(new MailboxAddress("HR","HRAPP@hr.com"));
                message.Subject = "Selamat Ulang Tahun " +i.name;
                message.Body = new TextPart("plain")
                {
                    Text = "Perusahaan mengucapkan Selamat Ulang Tahun\n"
                            +"Di hari istimewa ini Anda mendapakatkan Bonus\n"
                            +"Good Day"
                };
                using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
                {
                    emailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    emailClient.Connect("smtp.mailtrap.io", 587, false);
                    emailClient.Authenticate("e9bc7468600966", "089a1123f99e29");
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
                Console.WriteLine("NOT HAD BHIRTDAY");
                //Wait 10 minutes till next execution
                DateTime nextStop = DateTime.Now.AddDays(1);
                var timeToWait = nextStop - DateTime.Now;
                var millisToWait = timeToWait.TotalMilliseconds;
                Thread.Sleep((int)millisToWait);
            }
        }
    }
}