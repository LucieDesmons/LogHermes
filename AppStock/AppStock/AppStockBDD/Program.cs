using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AppStockBDD
{
    public class Article
    {
        public string name { get; set; }
        public string description { get; set; }
        public decimal note { get; set; }
        public DateTime année { get; set; }
        public string cépage { get; set; }

    }
public class ArticleContext : DbContext
    {
        public DbSet<Article> articles { get; set; }
    }
}
