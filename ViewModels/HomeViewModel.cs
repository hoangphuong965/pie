using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PieOfTheWeek { get; set; }

        public HomeViewModel(IEnumerable<Pie> pieOfTheWeek)
        {
            PieOfTheWeek = pieOfTheWeek;
        }
    }
}
