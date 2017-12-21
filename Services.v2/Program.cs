using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Services.v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            DbContextOptionsBuilder bldr = new DbContextOptionsBuilder();

            services.AddDbContext<OrderDirectoryContext>(options => options.UseSqlServer());
        }
    }
}
