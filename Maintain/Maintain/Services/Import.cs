﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintain.Services
{
    public abstract class Import
    {
        private bool sourceSet;

        public abstract bool Load();
    }
}
