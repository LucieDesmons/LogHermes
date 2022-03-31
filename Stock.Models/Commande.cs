namespace Stock.Models
{
   public class Commande
    {
        public int Id { get; set; }
        public DateTime? DateCmd { get; set; }

        public Client Client { get; set; }
    }
}
