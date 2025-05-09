using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class BusinessLogicService: IBusinessLogicService
    {
        private readonly IDatabase database;

        public BusinessLogicService(IDatabase database)
        {
            this.database = database;
        }

        public List<Table> DoSomething()
        {
            var tables = database.GetDataBase();
            return tables
                .Where(table => table.Material == "Steel" && table.Width * table.Lenght >= 1.5)
                .OrderByDescending(table => table.Width * table.Lenght)
                .ToList();
        }
    }
}
