using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using YellowBucket1.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using YellowBucket1.Models;
using Microsoft.EntityFrameworkCore;
using System.Timers;
using System.Threading;
//using Microsoft.AspNetCore.Identity;

namespace YellowBucket1 {
    public class Program {
        
        public static void Main(string[] args) {
            //var passwordHasher = new PasswordHasher<string>();
            //Console.WriteLine(passwordHasher.HashPassword(null, "strong password"));
            //Console.ReadLine();
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        private static void SetTimer(string[] args) {
            System.Timers.Timer aTimer;
            aTimer = new System.Timers.Timer(240000);
            aTimer.Elapsed += (OnTimedEvent);
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void CreateDbIfNotExists(IHost host) {
            using (var scope = host.Services.CreateScope()) {
                var services = scope.ServiceProvider;
                try {
                    var context = services.GetRequiredService<MoviesContext>();
                    context.Database.EnsureCreated();
                    /* DbInitializer.Initialize(context); */
                }
                catch (Exception ex) {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args) .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
