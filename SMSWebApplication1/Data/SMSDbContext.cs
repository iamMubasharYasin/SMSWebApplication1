using Microsoft.EntityFrameworkCore;
using SMSWebApplication1.Model;

namespace SMSWebApplication1.Data;

public class SMSDbContext : DbContext
{
    public SMSDbContext(DbContextOptions<SMSDbContext> options) : base(options)
    {
        
    }

    public DbSet<Student> tbl_student { get; set; }
}