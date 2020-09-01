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


        [Route("getallitems/{id}")]
        [HttpGet]
        public IList<Item> GetallItems(int id)
        {
            return _itemService.GetAllItems(id);
        }

        [Route("getitem/{id}")]
        [HttpGet]
        public Item GetItem(long id)
        {
            return _itemService.GetItem(id);
        }

        [Route("additem")]
        [HttpPost]
        public bool AddItem([FromBody]Item item)
        {
            if (item != null)
            {
                item.ItemId = 0;
                _itemService.AddItem(item);
                return true;
            }
            else return false;
        }

        [Route("removeitem/{id}")]
        [HttpDelete]
        public bool RemoveItem(long id)
        {
            _itemService.ArchiveItem(id);
            return true;
        }

        [Route("updateitem")]
        [HttpPost]
        public bool UpdateItem([FromBody] Item item)
        {
            if (item != null & item.ItemId > 0)
            {
                _itemService.UpdateItem(item);
                return true;
            }
            else return false;
        }
    }
}
