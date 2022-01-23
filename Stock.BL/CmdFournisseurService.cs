using Stock.DAL;

namespace Stock.BL
{
    public class CmdFournisseurService
    {
        private readonly DBLogHermesContext _context;

        public CmdFournisseurService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.CmdFournisseur> GetCmdFournisseurs()
        {
            return _context // DBLogHermesContext
                .CmdFournisseurs// DbSet<CmdFournisseur>
                .Select(f => new Models.CmdFournisseur
                {
                    Id = f.Id,
                    Libelle = f.Libelle,
                    DateCmd = f.DateCmd,
                    DateLivraison = f.DateLivraison,
                    MontantCmd = f.MontantCmd,
                    ModePaiement = f.ModePaiement,
                    PrixAchatHt = f.PrixAchatHt,
                    Taxe = f.Taxe
                })
                .ToList(); //List<CmdFournisseur>
        }
    }
}