﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Interfaces
{
  public  interface ILayoutService 
    {
        Task<Dictionary<string, string>> GetSettingsAsync();
    }
}
