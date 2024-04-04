using Maps.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps;
public static class AppCommandDefinitions
{
    public static void TestDb(MyDbContext context)
    {
        var db = context.Database;
        var v = context.Database.CanConnect();
        Console.WriteLine($"TestDb {db}");
    }
}
