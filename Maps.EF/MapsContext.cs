#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.EF.MapsContext.cs
// Created On    ::    16/07/2018 10:55
// Altered On    ::    16/07/2018 10:59
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Data.Entity;
using Maps.Data.Models;
using MySql.Data.Entity;

#endregion

namespace Maps.EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MapsContext : DbContext
    {
        public MapsContext() : base(Connections.GetConnectionString())
        {
        }

        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}