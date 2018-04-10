using System.Collections.Generic;
using LinqToDB;

namespace ConsoleAppSql
{
    public class DbNorthwind : LinqToDB.Data.DataConnection
    {
        public DbNorthwind() : base("TestData") { }

        public ITable<Product> Product => GetTable<Product>();
        //  public ITable<Category> Category => GetTable<Category>();

        // ... other tables ...
       
    }
}