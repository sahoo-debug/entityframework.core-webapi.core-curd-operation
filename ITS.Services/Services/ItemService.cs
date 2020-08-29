using ITS.Core.DBEntity;
using ITS.Core.IRepository;
using ITS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITS.Services.Services
{
  public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public IList<Item> GetAllItems(long stepId)
        {
            return _itemRepository.GetAllByFilter(x => x.StepId == stepId).ToList();
        }
        public Item GetItem(long id)
        {
            return _itemRepository.GetById(id);
        }
        public void AddItem(Item item)
        {
            _itemRepository.AddItem(item);
        }
        public void ArchiveItem(long id) 
        {
            _itemRepository.ArchiveItem(id);
        }
        public void UpdateItem(Item item) 
        {
            _itemRepository.UpdateItem(item);
        }
    }   
}
