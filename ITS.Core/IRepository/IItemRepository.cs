using ITS.Core.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITS.Core.IRepository
{
    public interface IItemRepository : IBaseRepository<Item>
    {
        void AddItem(Item item);
        void ArchiveItem(long id);
        void UpdateItem(Item item);
    }
}
