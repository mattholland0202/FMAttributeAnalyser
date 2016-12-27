﻿using FMAA.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMAA.BLL.Interfaces
{
    public interface IBLL
    {
        IUnitOfWork UnitOfWork { get; set; }

        IPlayers Players { get; set; }
    }
}