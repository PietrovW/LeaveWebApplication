﻿using System;

namespace Leave.Core.Entitys.Base
{
    public abstract class TEntity
    {
        public int Id { get; set; }
        public DateTime Inserted { get; set; }
        public DateTime Updated { get; set; }
        public int FVer { get; set; }
    }
}
