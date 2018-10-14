using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.DAL.Models.Base
{
    public abstract class TEntity
    {
        
        public Guid Id { get; set; }

        public DateTime Inserted { get; set; }

        public DateTime Updated { get; set; }
        public int FVer { get; set; }
    }
}
