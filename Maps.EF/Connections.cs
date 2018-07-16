#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.EF.Connections.cs
// Created On    ::    13/07/2018 07:40
// Altered On    ::    13/07/2018 07:42
// By            ::    Arjan Crielaard

#endregion

namespace Maps.EF
{
    public static class Connections
    {
        public static string GetConnectionString()
        {
            var dbname = "maps";

            if (string.IsNullOrEmpty(dbname)) return null;

            var username = "root";
            var password = "5j@G!m4(u[([~e-9yeL2k*(g";
            var server = "localhost";
            var port = "3306";
            return $"Server={server}; Database={dbname};Uid={username};Pwd={password};";
        }
    }
}