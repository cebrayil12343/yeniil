namespace _1yanvar.Models
{
    public class PortfolioImage
    {
        public int id { get; set; }
        public string ImageUrl { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
