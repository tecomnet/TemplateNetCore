using Microsoft.EntityFrameworkCore;

namespace Template.DOM.ApplicationDbContext;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    
    
    
}