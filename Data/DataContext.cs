using Microsoft.EntityFrameworkCore;

namespace EfCoreKursApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Kurs> Kurslar => Set<Kurs>();
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();
    }

    
}