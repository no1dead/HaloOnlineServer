﻿using System.Collections.Generic;

namespace HaloOnline.Server.Model.SessionControl
{
    public class SessionChain
    {
        public string User { get; set; }
        public List<Game> Sessions { get; set; }
    }
}
