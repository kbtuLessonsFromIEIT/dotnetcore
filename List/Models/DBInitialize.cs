using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace List.Models
{
    public static class DBInitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new ApplicationDBContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDBContext>>());
            context.Database.EnsureCreated();
        }
    }
}