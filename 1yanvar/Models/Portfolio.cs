using System.ComponentModel.DataAnnotations;

namespace _1yanvar.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        
        public int CatagoriId { get; set; }
        
        [StringLength (maximumLength:20)]
        public string Title { get; set; }
        [StringLength(maximumLength: 200)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 22)]
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string ProjectUrl { get; set; }
        public Catagori Catagori { get; set; }
        public List<PortfolioImage> PortfolioImage { get; set; }

    }
}
