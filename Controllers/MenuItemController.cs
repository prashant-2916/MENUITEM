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
            {   new MenuItem() {Id=1, Name="MILKSHAKE", Active=true, DateOfLaunch=new DateTime(2022,10,06), FreeDelivery=false,Price=5000},
                new MenuItem() {Id=2, Name="PIZZA", Active=false, DateOfLaunch=new DateTime(2022,10,06), FreeDelivery=false,Price=20000}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="MILKSHAKE", Active=true, DateOfLaunch=new DateTime(2022,10,06), FreeDelivery=false,Price=5000},
                new MenuItem() {Id=2, Name="PIZZA", Active=false, DateOfLaunch=new DateTime(2022,10,06), FreeDelivery=false,Price=20000}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
            
        }

    }
}
