﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using R2.Data.NoSql.MongoDb.Api.Domain.Interface;
using R2.Data.NoSql.MongoDb.Api.Infra.Repository;
using R2.Data.NoSql.MongoDb.Configuration;
using Swashbuckle.AspNetCore.Swagger;

namespace R2.Data.NoSql.MongoDb.Api
{
    public class Startup
    {
        private const string SwaggerUrl = "/swagger/v1/swagger.json";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "R2Dev Teste Cassandra API", Version = "v1" });
            });

            services.AddMongoDb(Configuration);

            services.AddSingleton<IUserRepository, UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(SwaggerUrl, "Contacts API V1");
            });
        }
    }
}
