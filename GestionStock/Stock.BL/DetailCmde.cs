using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    public class DetailCmde
    {
        public static List<DetailCmde> listeDetail=new List<DetailCmde>();
        public int Id { get; set; }
        public string Nom { get; set; }
        public int quantite { get; set; }
        public string prix { get; set; }
        public string remise { get; set; }
        public string total { get; set; }

    }
}
