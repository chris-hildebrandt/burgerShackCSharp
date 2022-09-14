using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgerShackCSharp.Models;
using burgerShackCSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgerShackCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // this VVV extends the basecontroller like in js
    public class BurgersController : ControllerBase
    {
        private readonly BurgersService _burgersService;
        public BurgersController(BurgersService burgersService){
            _burgersService = burgersService;
        }

        [HttpGet]
        public ActionResult<List<Burger>> GetBurgers()
        { try
        {
            List<Burger> burgers = _burgersService.GetBurgers();
            return Ok(burgers);
        }
        catch (System.Exception e)
        {
            
            return BadRequest(e.Message);
        }}

        [HttpGet("{id}")]
        public ActionResult<Burger> GetBurgerById(int id){
            try
            {
                Burger burger = _burgersService.GetBurgerById(id);
                return Ok(burger);
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Burger> CreateBurger([FromBody] Burger body){
            try
            {
                Burger burger = _burgersService.CreateBurger(body);
                return Ok(burger);
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
    }
}