

namespace PryUserRuizFloresMR.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PryUserRuizFloresMR.Models.Geo> Geos { get; set; }

        public System.Data.Entity.DbSet<PryUserRuizFloresMR.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<PryUserRuizFloresMR.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<PryUserRuizFloresMR.Models.Root> Roots { get; set; }
    }
}