﻿using Domain.Interfaces.DbObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepository
    {
        IEnumerable<ICompany> GetCompanies();
    }
}
