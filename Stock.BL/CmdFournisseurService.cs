using Stock.DAL;

namespace Stock.BL
{
    public class CmdFournisseurService
    {
        
        private readonly DBLogHermesContext _context;
        private CmdFournisseur CmdFournisseur;

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

        public void CreateCmdFournisseurs(Models.CmdFournisseur cmdFournisseur)
        {
           
            _context // DBLogHermesContext
                .CmdFournisseurs// DbSet<CmdFournisseur>
                .Add(new CmdFournisseur
                { 
                    Id = cmdFournisseur.Id,
                    Libelle = cmdFournisseur.Libelle,
                    DateCmd = cmdFournisseur.DateCmd,
                    DateLivraison = cmdFournisseur.DateLivraison,
                    MontantCmd = cmdFournisseur.MontantCmd,
                    ModePaiement = cmdFournisseur.ModePaiement,
                    PrixAchatHt = cmdFournisseur.PrixAchatHt,
                    Taxe = cmdFournisseur.Taxe
                })
                .Context
                .SaveChanges();
        }         
    }
}
