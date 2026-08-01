using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SkillManager: ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
