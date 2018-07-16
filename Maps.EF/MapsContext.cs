#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.EF.MapsContext.cs
// Created On    ::    12/07/2018 12:39
// Altered On    ::    12/07/2018 12:40
// By            ::    Arjan Crielaard

#endregion

using System;
using System.Data.Entity;
using Maps.Data.Models;
using MySql.Data.Entity;

namespace Maps.EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MapsContext : DbContext
    {
        public MapsContext() : base("maps")
        {

        }

        public DbSet<Trainee> Trainees { get; set; }
    }
}