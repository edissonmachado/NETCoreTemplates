using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCAuthenticationCore22Template.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MVCAuthenticationCore22Template.Areas.Identity.IdentityHostingStartup))]
namespace MVCAuthenticationCore22Template.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCAuthenticationCore22TemplateIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCAuthenticationCore22TemplateIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<MVCAuthenticationCore22TemplateIdentityDbContext>();
            });
        }
    }
}