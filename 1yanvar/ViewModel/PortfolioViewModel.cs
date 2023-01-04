using _1yanvar.Models;
using System.ComponentModel;

namespace _1yanvar.ViewModel
{
    public class PortfolioViewModel
    {
        public List<Catagori> catagoris { get; set; }
        public List<Portfolio> Portfolio { get; set; }
        public List<PortfolioImage> PortfolioImages { get; set; }   
    }
}
