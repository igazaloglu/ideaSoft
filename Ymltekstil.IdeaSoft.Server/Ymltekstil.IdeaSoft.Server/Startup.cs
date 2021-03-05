﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ymltekstil.IdeaSoft.Server.Database;
using Ymltekstil.IdeaSoft.Server.Interfaces;
using Ymltekstil.IdeaSoft.Server.Models;
using Ymltekstil.IdeaSoft.Server.Services;

namespace Ymltekstil.IdeaSoft.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<IIdeaSoftClient, IdeaSoftClient>();
            services.AddTransient<IDbSettingsService, DbSettingsService>();

            services.AddCors();

            services.AddOptions<Settings>().Bind(Configuration.GetSection("Settings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
            }

            app.UseDeveloperExceptionPage();
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();



            app.UseCors(options => options.WithOrigins("https://localhost:5001", "http://localhost:5000").AllowAnyMethod());

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
