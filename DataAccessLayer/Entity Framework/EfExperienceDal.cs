using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entity_Framework
{
    public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal
    {
    }
}
