﻿using System;
using System.Collections.Generic;

namespace Web_xemphim.Data
{
    public partial class MovieActor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; } = null!;
        public virtual Movie Movie { get; set; } = null!;
    }
}
