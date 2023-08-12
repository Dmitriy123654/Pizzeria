using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){ ImageTitle="Margerita", PizzaName="Margerita", BasePrice = 8, TomatoSause=true, Cheese=true, FinalPrice=17},
            new PizzasModel(){ ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice = 8, TomatoSause=true, Cheese=true,  Beef=true, Chiken=true, FinalPrice=20},
            new PizzasModel(){ ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice = 8, TomatoSause=true, Cheese=true, Ham=true,Pineapple=true,Chiken=true, FinalPrice=22},
            new PizzasModel(){ ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice = 8, TomatoSause=true, Cheese=true,Ham=true,Mushroom=true, FinalPrice=20},
            new PizzasModel(){ ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice = 8, TomatoSause=true, Cheese=true, Ham=true, Beef=true, Chiken=true, Peperoni=true, Mushroom=true, FinalPrice=25},
            new PizzasModel(){ ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice = 8, TomatoSause=true, Cheese=true,Mushroom=true, FinalPrice=16},
            new PizzasModel(){ ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice = 8, TomatoSause=true, Cheese=true, Peperoni=true,FinalPrice=17},
            new PizzasModel(){ ImageTitle="Seafood", PizzaName="Seafood", BasePrice = 8, TomatoSause=true, Cheese=true, Pineapple=true, Beef=true, Mushroom=true,Peperoni = true,Chiken=true, Ham=true, FinalPrice=26},
            new PizzasModel(){ ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice = 8, TomatoSause=true, Cheese=true, Mushroom=true,Pineapple=true, FinalPrice=20},
            
        };

    }
}
