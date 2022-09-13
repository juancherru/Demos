using Microsoft.EntityFrameworkCore;
using MusicStoreMVC.Models;

namespace MusicStoreMVC.Data
{
    public class MusicStoreMVCContext : DbContext
    {
        public MusicStoreMVCContext(DbContextOptions<MusicStoreMVCContext> options) : base(options)
        {
            
        }

        public DbSet<Producto> Productos {get;set;}

    }
}
