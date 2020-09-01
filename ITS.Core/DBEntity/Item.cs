using System;
using System.Collections.Generic;

namespace ITS.Core.DBEntity
{
    public partial class Item
    {
        public long ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public long StepId { get; set; }

        public virtual Step Step { get; set; }
    }
}
