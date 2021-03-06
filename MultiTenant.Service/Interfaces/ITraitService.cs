﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiTenant.Model;

namespace MultiTenant.Service.Interfaces
{
    public interface ITraitService
    {
        void DeleteTrait(int id);
        IEnumerable<Trait> GetAddTraits();
        IEnumerable<Trait> GetViewTraits();
    }
}
