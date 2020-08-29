using ITS.Core.DBEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITS.Services.Contracts
{
    public interface IItemService
    {
        IList<Item> GetAllItems(long stepId);
        Item GetItem(long id);
        void AddItem(Item item);
        void ArchiveItem(long id);
        void UpdateItem(Item item);
    }
}
