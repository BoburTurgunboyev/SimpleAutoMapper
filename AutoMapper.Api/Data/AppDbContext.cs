using AutoMapper.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMapper.Api.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
        public DbSet<User> users { get; set; }
    }
}
