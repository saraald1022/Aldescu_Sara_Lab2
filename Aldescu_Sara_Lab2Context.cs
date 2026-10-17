using Microsoft.EntityFrameworkCore;

public class Aldescu_Sara_Lab2Context(DbContextOptions<Aldescu_Sara_Lab2Context> options) : DbContext(options)
{
    public DbSet<Aldescu_Sara_Lab2.Models.Book> Book { get; set; } = default!;
}
