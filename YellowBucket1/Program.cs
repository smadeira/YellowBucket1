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

namespace YellowBucket1 {
    public class Program {
        /* private static System.Timers.Timer aTimer; */
        
        public static void Main(string[] args) {
            /* MyProcess.Program(); */
            /* CreateDbIfNotExists(host); */

            /* Stopwatch stopwatch = Stopwatch.StartNew(); */
            /* while (true) */
            /* { */
            /*     //some other processing to do STILL POSSIBLE */
            /*    if (stopwatch.ElapsedMilliseconds >= 240000) */
            /*     { */
            /*         break; */
            /*     } */
            /*     Thread.Sleep(4000); //so processor can rest for a while */
            /* } */
            var host = CreateHostBuilder(args).Build();
            host.Run();
            /* var context = new MoviesContext(new DbContextOptions<MoviesContext>()); */
            
            /*    var count = context.Movies.FromSqlRaw */
            /*   ("SELECT COUNT(*) FROM dbo.Movies"); */
        }

        private static void SetTimer(string[] args) {
            System.Timers.Timer aTimer;
            /* Create a timer with a two second interval. */
            aTimer = new System.Timers.Timer(240000);
            /* Hook up the Elapsed event for the timer. */ 
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
