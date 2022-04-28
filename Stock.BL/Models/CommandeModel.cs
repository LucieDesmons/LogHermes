namespace GestionStock.BL.Models
{
    public class CommandeModel
    {
        public int Id { get; set; }
        public DateTime DateCmd { get; set; }
        public string? TotalHT { get; set; }
        public string? TVA { get; set; }
        public string? TotalTTC { get; set; }

        public ClientModel Client { get; set; }
    }
}
