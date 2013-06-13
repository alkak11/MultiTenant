﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiTenant.Model;

namespace MultiTenant.Repository
{
    public interface IStoreRepository
    {
        IEnumerable<Store> GetStores();
    }
}