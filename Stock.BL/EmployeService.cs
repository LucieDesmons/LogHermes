using Stock.DAL;

namespace Stock.BL
{
    public class EmployeService
    {
        private readonly DBLogHermesContext _context;

        public EmployeService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Employe> GetEmployes()
        {
            return _context // DBLogHermesContext
                .Employes// DbSet<Employes>
                .Select(e => new Models.Employe
                {
                    Id = e.Id,
                    Nom = e.Nom,
                    Prenom = e.Prenom,
                    Role = e.Role
                })
                .ToList(); //List<Employes>
        }
    }
}