﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface ILoaiRepository
    {
        List<LoaiModel> GetDataAll();
    }
}
