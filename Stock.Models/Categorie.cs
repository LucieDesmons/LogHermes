using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string? Nature { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
