﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacecapsCase.Infrastructure.Data.Interfaces
{
    public interface IAdd<TEntity>
    {
        TEntity Add(TEntity entity);
    }
}
