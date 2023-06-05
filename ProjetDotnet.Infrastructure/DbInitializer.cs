using Microsoft.EntityFrameworkCore;

namespace ProjetDotnet.Infrastructure;

public static class DbInitializer
{
    public static void Initialize(DbContext context)
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        context.SaveChanges();
    }
}