using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public double PizzaPrice { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSause) PizzaPrice += 0.5;
            if (Pizza.Beef) PizzaPrice += 2;
            if (Pizza.Cheese) PizzaPrice +=3;
            if (Pizza.Chiken) PizzaPrice += 2;
            if (Pizza.Ham) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 1.5;
            if (Pizza.Peperoni) PizzaPrice += 1.5;
            if (Pizza.Pineapple) PizzaPrice += 2;

            return RedirectToPage("/Make_order/Make_order", new { Pizza.PizzaName, PizzaPrice });

        }
    }
}
