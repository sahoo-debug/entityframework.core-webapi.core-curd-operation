using ITS.Core.DBEntity;
using ITS.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITS.Core.Repository
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        protected SKSTestDBContext _context;
        public ItemRepository(SKSTestDBContext context) : base(context)
        {
            _context = context;
        }

        public void AddItem(Item item)
        {
           item.IsActive = true;
           Add(item);
        }
        public void ArchiveItem(long id)
        {
            var entity = _context.Item.Where(x => x.ItemId == id).FirstOrDefault();
            if(entity != null)
            {
                entity.IsActive = false;
                Update(entity);
            }
        }

        public void UpdateItem(Item item)
        {
            var entity = _context.Item.Where(x => x.ItemId == item.ItemId).FirstOrDefault();
            if (entity != null)
            {
                entity.Title = item.Title;
                entity.Description = item.Description;
                Update(entity);
            }
        }
    }
}
