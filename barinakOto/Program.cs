using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;
using barinakOto.Models;

namespace barinakOto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Host oluþturma ve servisleri yapýlandýrma
            var host = CreateHostBuilder().Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<HayvanSahiplendirmeDbContext>();
                    // Ýlk çalýþtýrmada veritabanýnýn var olduðundan emin olun (Database First olduðu için migrationa gerek yok)
                    // context.Database.EnsureCreated(); // Migration kullanmýyorsan bu satýrý kullanabilirsin
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabaný baðlantý hatasý: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Ana formu servis saðlayýcýdan alarak baþlatma
            Application.Run(host.Services.GetRequiredService<frm_login>());


            static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                //.ConfigureAppConfiguration((context, builder) =>
                //{
                //    // appsettings.json dosyasýný ekle
                //    builder.SetBasePath(Directory.GetCurrentDirectory())
                //           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                //})
                .ConfigureServices((context, services) =>
                {
                    // DbContext'i servislere ekle
                    services.AddDbContext<HayvanSahiplendirmeDbContext>(options =>
                        options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection"))
                    );

                    // Formlarý da servis olarak ekle (gerekirse)
                    services.AddTransient<frm_login>();
                    services.AddTransient<frm_menu>();
                    services.AddTransient<frm_animals>();
                    services.AddTransient<frm_veteriner>();
                    services.AddTransient<frm_gonulluler>();
                    services.AddTransient<frm_sahiplenen>();
                    services.AddTransient<frm_personel>();


                });
        }

      
    }
}