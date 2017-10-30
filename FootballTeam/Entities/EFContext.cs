using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam.Entities
{
    public partial class EFContext : DbContext
    {
        public EFContext()
            : base("DBCS")
        {
        }
        public virtual DbSet<Human> Humans { get; set; }

        public virtual DbSet<HumanInfo> HumansInfo { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Team> Teams { get; set; }

    }
}
