#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.Reader.cs
// Created On    ::    12/07/2018 07:57
// Altered On    ::    12/07/2018 07:57
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.IO;
using System.Reflection;

#endregion

namespace Maps.Data.Tools
{
    internal static class Reader
    {
        internal static string GetResourceFile(string filename)
        {
            var result = string.Empty;

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Maps.Data.Tools." + filename))
            {
                using (var sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }
    }
}