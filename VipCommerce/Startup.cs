using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infra.EntityFramework.Repositories;
using App.IServices;
using App.Services;
using App.Services.Produto;
using Infra.EntityFramework.Repositories.Produto;
using Infra.EntityFramework.Repositories.Cliente;

namespace WebApi
{
  public class Startup
  {
    private readonly IConfiguration configuration;

    public Startup(IConfiguration configuration)
    {
      this.configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      var conn = configuration["ConnectionString:Default"];
      services.AddDbContext<MySqlContext>(opt =>
      {
        opt.UseMySql(conn);
      });

      services.AddScoped<IProdutoAppService, ProdutoAppService>();
      services.AddScoped<IProdutoRepository, ProdutoRepository>();
      services.AddScoped<IClienteRepository, ClienteRepository>();

      services.AddMvcCore()
        .AddJsonFormatters()
        .AddDataAnnotations();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc();      
    }
  }
}
