
 using System;
namespace ConsoleAppSql
{
   
           
    class Program
    {
        static void Main(string[] args)
        {
            Repo repo=new Repo();
            for (int i = 0; i < 20; i++)
            {
                repo.Add(new Product(){Name=$"aaa{i}"});
            }
            var ret= repo.All("1");

            foreach (var r in ret)
            {
                Console.WriteLine(r.Name);
            }
            Console.ReadLine();
        }
       

    }
    
}
