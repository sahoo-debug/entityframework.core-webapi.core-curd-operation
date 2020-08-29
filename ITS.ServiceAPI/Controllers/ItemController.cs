using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITS.Core.DBEntity;
using ITS.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITS.ServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }


        [Route("getallitems")]
        [HttpGet]
        public IList<Item> GetallItems()
        {
            return _itemService.GetAllItems(1);
        }

        [Route("getitem/{id}")]
        [HttpGet]
        public Item GetItem(long id)
        {
            return _itemService.GetItem(id);
        }

        [Route("additem")]
        [HttpGet]
        public bool AddItem()
        {
            var item = new Item { Title = "title_", Description = "updated description_", StepId =1 };
            _itemService.AddItem(item);
            return true;
        }

        [Route("removeitem")]
        [HttpGet]
        public bool RemoveItem()
        {
            _itemService.ArchiveItem(3);
            return true;
        }

        [Route("updateitem")]
        [HttpGet]
        public bool UpdateItem()
        {
            var item = new Item { Title="updated title", Description="updated description" };
            _itemService.UpdateItem(item);
            return true;
        }

    }
}
