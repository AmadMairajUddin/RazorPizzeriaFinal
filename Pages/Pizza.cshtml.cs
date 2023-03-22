using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                FinalPrice=4 },
                new PizzasModel(){ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                FinalPrice=4 },
            new PizzasModel(){ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                FinalPrice=4 },
            new PizzasModel(){ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                Mushrooms = true,
                Cheese=true,
                FinalPrice=4 },
        };

        public void OnGet()
        {
        }
    }
}