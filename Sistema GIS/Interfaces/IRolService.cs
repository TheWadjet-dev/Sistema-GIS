﻿//using Sistema_GIS.Entiity:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_GIS.Interfaces
{
    public interface IRolService
    {
        Task<List<Rol>> Lista();
    }
}