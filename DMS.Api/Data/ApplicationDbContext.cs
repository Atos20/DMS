using Microsoft.EntityFrameworkCore;

namespace DMS.Api;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }
}

