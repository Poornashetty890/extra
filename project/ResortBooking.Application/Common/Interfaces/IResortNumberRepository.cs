﻿using ResortBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResortBooking.Application.Common.Interfaces
{
    public interface IResortNumberRepository : IRepository<ResortNumber>
    {
       
        void Update(ResortNumber entity);
       
    }
}
