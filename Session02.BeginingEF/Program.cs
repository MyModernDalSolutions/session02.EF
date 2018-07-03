using Microsoft.EntityFrameworkCore;
using System;

namespace Session02.BeginingEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyAppContext())
            {
                //InitialiseDB(ctx);
                //AddRecord(ctx);
                //ReadFromDB(ctx);
            }




            Console.ReadKey();

        }

        private static void ReadFromDB(MyAppContext ctx)
        {
            #region ReadFromDB
            foreach (var c in ctx.Categories.Include(c => c.Products))
            {
                Console.WriteLine($"Category : {c.Name}");
                foreach (var p in c.Products)
                {
                    Console.WriteLine($"     Product : {p.Name}");
                }
            }
            #endregion
        }

        private static void AddRecord(MyAppContext ctx)
        {
            #region Add Record
            var category = new Category
            {
                Name = "laptop"
            };
            category.Products.Add(new Product
            { Name = "N43 sm" });

            ctx.Categories.Add(category);
            ctx.SaveChanges();
            #endregion
        }
        /// <summary>
        /// در محیط عملیاتی این کار را
        /// انجام ندهید
        /// خطر ناک است 
        /// اگر دیتا بیس شما به هر دلیلی بالا نیاید
        /// یک دیتا بیس خالی ایجاد میکند 
        /// </summary>
        /// <param name="ctx"></param>
        private static void InitialiseDB(MyAppContext ctx)
        {
           
            ctx.Database.EnsureCreated();
        }
    }
}
