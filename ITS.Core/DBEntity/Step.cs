using System;
using System.Collections.Generic;

namespace ITS.Core.DBEntity
{
    public partial class Step
    {
        public Step()
        {
            Item = new HashSet<Item>();
        }

        public long StepId { get; set; }
        public string StepName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}
