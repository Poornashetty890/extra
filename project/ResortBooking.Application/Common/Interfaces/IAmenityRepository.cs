﻿using ResortBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResortBooking.Application.Common.Interfaces
{
    public interface IAmenityRepository : IRepository<Amenity>
    {
       
        void Update(Amenity entity);
       
    }
}
