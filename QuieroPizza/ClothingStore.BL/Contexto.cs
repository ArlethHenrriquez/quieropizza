using System.Data.Entity;

namespace ClothingStore.BL
{
    public  class Contexto: DbContext
    {
        public Contexto() :base("ClothingStoreDB")
        {

        }

        public DbSet<producto> Productos { get; set; }

    }
}
