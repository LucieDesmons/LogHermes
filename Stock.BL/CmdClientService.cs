using Stock.DAL;

namespace Stock.BL
{
   public class CmdClientService
    {
        private readonly DBLogHermesContext _context;

        public CmdClientService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.CmdClient> GetCmdClients()
        {
            return _context // DBLogHermesContext
                .CmdClients// DbSet<CmdClient>
                .Select(c => new Models.CmdClient
                {
                    Id = c.Id,
                    DateCmd = c.DateCmd,
                    DateLivraison = c.DateLivraison,
                    Devise = c.Devise,
                    Libelle = c.Libelle,
                    LieuLivraison = c.LieuLivraison,
                    MontantCmd = c.MontantCmd,
                    ModePaiement = c.ModePaiement,
                    Etat = c.Etat
               
                })
                .ToList(); //List<CmdClient>
        }
    }
}
