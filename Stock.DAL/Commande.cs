namespace Stock.DAL
{
    public partial class Commande
    {

        public int Id { get; set; }
        public DateTime? DateCmd { get; set; }

        public Client Client { get; set; }

    }
}

