﻿using Core.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategortDal : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
       
    }
}
