using Stock.DAL;

namespace Stock.BL
{
    public class StockService
    {
        private readonly DBLogHermesContext _context;

        public StockService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Stock.Models.Stocks> GetStocks()
        {
            return _context // DBLogHermesContext
                .EmplacementStocks// DbSet<EmplacementStock>
                .Select(s => new Models.Stocks
                {
                    Id = s.Id,
                    NumRang = s.NumRang,
                    NumCasier = s.NumCasier
                })
                .ToList(); //List<EmplacementStock>
        }
    }
}