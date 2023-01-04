using _1yanvar.Models;
using _1yanvar.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1yanvar.Controllers
{
    public class PortfolioController1 : Controller
    {
        private readonly DataContext _datacontext;

        public PortfolioController1(DataContext dataContext)
        {
            _datacontext = dataContext;
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioViewModel = new PortfolioViewModel
            {
                Portfolio = _datacontext.Portfolio.Include(X => X.Catagori).ToList(),
                catagoris = _datacontext.Catagori.ToList()
            };

            return View(portfolioViewModel);
        }
        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _datacontext.Portfolio.Include(portf => portf.Catagori).FirstOrDefault(port => port.Id == id);
            if (portfolio == null) return NotFound();
            return View(portfolio);
        }
    }
}
