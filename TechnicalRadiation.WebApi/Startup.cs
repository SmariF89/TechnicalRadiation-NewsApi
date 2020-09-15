using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;

namespace TechnicalRadiation.WebApi
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<NewsItemInputModel, NewsItem>()
                    .ForMember(m => m.CreatedDate, opt => opt.UseValue(DateTime.Now))
                    .ForMember(m => m.ModifiedDate, opt => opt.UseValue(DateTime.Now))
                    .ForMember(m => m.ModifiedBy, opt => opt.UseValue("newsWriter"));
                cfg.CreateMap<CategoryInputModel, Category>()
                    .ForMember(m => m.CreatedDate, opt => opt.UseValue(DateTime.Now))
                    .ForMember(m => m.ModifiedDate, opt => opt.UseValue(DateTime.Now))
                    .ForMember(m => m.ModifiedBy, opt => opt.UseValue("categoryBuilder"));
                cfg.CreateMap<AuthorInputModel, Author>()
                    .ForMember(m => m.CreatedDate, opt => opt.UseValue(DateTime.Now))
                    .ForMember(m => m.ModifiedDate, opt => opt.UseValue(DateTime.Now))
                    .ForMember(m => m.ModifiedBy, opt => opt.UseValue("authorMaker"));
            });

        }
    }
}
