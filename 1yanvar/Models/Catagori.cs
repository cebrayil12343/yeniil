using System.ComponentModel.DataAnnotations;

namespace _1yanvar.Models
{
    public class Catagori
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:28)]
        public string Name { get; set; }
        public List<Portfolio> PortfolioC { get; set; }
        
    }
}
