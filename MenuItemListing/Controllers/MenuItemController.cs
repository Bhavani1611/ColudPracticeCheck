using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   
            new MenuItem() { Id = 1, Name = "Briyani",Price = 150,FreeDelivery = true,DateOfLaunch = new DateTime(2022,4,10),Active = true },
            new MenuItem() { Id = 2, Name = "Dosa",Price = 60,FreeDelivery = true,DateOfLaunch = new DateTime(2022,4,2),Active = true },
            new MenuItem() { Id = 3, Name = "Pasta",Price = 100,FreeDelivery = true,DateOfLaunch = new DateTime(2022,3,20),Active = false },
            new MenuItem() { Id = 4, Name = "Pizza",Price = 250,FreeDelivery = false,DateOfLaunch = new DateTime(2022,4,5),Active=true },
            new MenuItem() { Id = 5, Name = "Noodles",Price = 100,FreeDelivery = false,DateOfLaunch = new DateTime(2022,5,1),Active=true },

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
            new MenuItem() { Id = 1, Name = "Briyani",Price = 150,FreeDelivery = true,DateOfLaunch = new DateTime(2022,4,10),Active = true },
            new MenuItem() { Id = 2, Name = "Dosa",Price = 60,FreeDelivery = true,DateOfLaunch = new DateTime(2022,4,2),Active = true },
            new MenuItem() { Id = 3, Name = "Pasta",Price = 100,FreeDelivery = true,DateOfLaunch = new DateTime(2022,3,20),Active = false },
            new MenuItem() { Id = 4, Name = "Pizza",Price = 250,FreeDelivery = false,DateOfLaunch = new DateTime(2022,4,5),Active=true },
            new MenuItem() { Id = 5, Name = "Noodles",Price = 100,FreeDelivery = false,DateOfLaunch = new DateTime(2022,5,1),Active=true },

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
            
        }

    }
}
