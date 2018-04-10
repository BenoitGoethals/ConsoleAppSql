using System.Collections.Generic;
using System.Linq;
using LinqToDB;

namespace ConsoleAppSql
{
    public class Repo
    {
        public void Add(Product product)
        {
            using (var db = new DbNorthwind())
            {
                db.Insert(product);
            }
        }


        public  List<Product> All()
        {
            using (var db = new DbNorthwind())
            {
                var query = from p in db.Product
                    where p.ProductID > 25
                    orderby p.Name descending
                    select p;
                return query.ToList();
            }
        }

        public List<Product> All(string name)
        {
            using (var db = new DbNorthwind())
            {
                var query = from p in db.Product
                    where p.Name.Contains(name)
                  
                    select p;
                return query.ToList();
            }
        }
    }
}