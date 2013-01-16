using System.Data.Entity;

namespace Kiki.Infrastructure.Contexts
{
    public class KikiContext : DbContext
    {
        public KikiContext(string connectString)
        {
            Database.Connection.ConnectionString = connectString;
            Database.SetInitializer<KikiContext>(null);
        }

        public DbSet<Models.Kiki> Kikis { get; set; }
    }
}
