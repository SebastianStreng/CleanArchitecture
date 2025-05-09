using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Infrastructure.external;

public class Database: IDatabase
{
    IEnumerable<Table> IDatabase.GetDataBase()
    {
        var random = new Random();
        var materials = new[] { "Wood", "Plastic", "Steel", "Glass", "Aluminum" };
        List<Table> tables = new List<Table>();

        for (int i = 0; i < 7; i++)
        {
            double width = Math.Round(random.NextDouble() * 2, 2);
            double length = Math.Round(random.NextDouble() * 2, 2);
            double height = Math.Round(random.NextDouble() * 1, 2);
            string material = materials[random.Next(materials.Length)];

            Table table = new Table(height, width, length, material);
            tables.Add(table);
        }

        tables.Add(new Table(0.75, 1.5, 1.2, "Steel"));
        tables.Add(new Table(0.80, 2.0, 1.0, "Steel"));
        tables.Add(new Table(0.90, 1.6, 1.1, "Steel"));

        return tables;
    }

}
