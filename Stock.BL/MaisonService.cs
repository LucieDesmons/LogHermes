using GestionStock.DAL;
using GestionStock.BL.Models;
using System.Linq;

namespace GestionStock.BL
{
    public class MaisonService
    {
        private readonly DBGestionStockContext _context;

        public MaisonService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<MaisonModel> GetMaisons()
        {
            return _context
                .Maisons
                .Select(c => new MaisonModel
                {
                    IDMAISON = c.IDMAISON,
                    NomMaison = c.NomMaison     

                })
                .ToList();
        }


        public void CreateMaison(MaisonModel maison)
        {

            _context
                .Maisons
                .Add(new Maison
                {
                    IDMAISON = maison.IDMAISON,
                    NomMaison = maison.NomMaison
                })
                .Context
                .SaveChanges();
        }

    }
}
