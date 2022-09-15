//konsole aplication oluşturduk, o console applicationa entitiy framework core implemente edicez
//database implematasyonu yapıcaz ,context yaratacağız, mevcut bookstore apllicationda olduğu gibi 
//bir enttity yaratıp o entity verilerine linq kullanarak erişmeye çalışacağız.
//LINQ .Net Framework 3.5 ve Visual Studio 2008 ile hayatımıza giren farklı data source yani veri kaynaklarını sorgulamamıza yarayan bir dildir. LINQ Visual Basic ve C# ile birlikte kullanılabilir.
//bir Contexte ihtiya var bir db context olabilmesi için klasının oması gerekiyor. DbContext SINIFNDAN 
//kalıtım alması gerekiyor . Contexte olaca entitileri yaratalım
using Microsoft.EntityFrameworkCore;

namespace linqpratik.DBOperations
{
    public class LinqContextDb: DbContext
    {
        //artık bir entitiy var bu context içerisine eklenebiir durumda  contexe gidip kendi entitim ekliycem
        public DbSet<Student> Students { get; set; }
        //inmemory database kullnıcaz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName:"LinqDatabase");
        }
    }
}