using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]

public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }

    //GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>  //the action result type is the base class
    PizzaService.GetAll();                        //for all action results in ASP.NET
    //GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null){
            return NotFound();
        }
        return pizza;
    }
    //POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza); //Actual creation
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza); //A status code
    }
    //PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id,Pizza pizza)
    {
        if (id != pizza.Id){
            return BadRequest();
        }

        var existingPizza = PizzaService.Get(id);
        if(existingPizza is null){
            return NotFound();
        }
        
        PizzaService.Update(pizza);
        return NoContent();
    } 
    //DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id, Pizza pizza)
    {
        if(id != pizza.Id)
        {
            return BadRequest();
        }
        var existingPizza = PizzaService.Get(id);
        PizzaService.Delete(id);
        return NoContent();
    }
}