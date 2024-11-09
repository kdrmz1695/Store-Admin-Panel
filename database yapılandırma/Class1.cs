using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocTasMall.database_codefirst
{
    internal class Class1
    {
    }
}

public class KocTasDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<PCategory> PCategories { get; set; }

    


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = (localdb)\\ProjectModels; Database = KocTasDb; User Id=muko; Password=muko123; Trusted_Connection = True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.pCategory)
            .WithMany(c => c.products)
            .HasForeignKey(p => p.PCategoryId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

       
    }
}

public class Product
{
    
    public int? Id { get; set; }
    public string ProductName { get; set; }
    public int? Price { get; set; }
    public PCategory pCategory { get; set; }
    public int? PCategoryId { get; set; }

    public bool? IsDeleted { get; set; }
}

public class PCategory
{
    public PCategory()
    {
        products = new HashSet<Product>();
    }
    public int? Id { get; set; }
    public string CategoryName { get; set; }
    public ICollection<Product> products { get; set; }

    public bool? IsDeleted { get; set; }

}


