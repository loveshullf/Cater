using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class DishTypeInfoBll
    {
        private readonly DishTypeInfoDal _dtiDal=new DishTypeInfoDal();

        public List<DishTypeInfo> GetList()
        {
            return _dtiDal.GetList();
        }

        public bool Add(DishTypeInfo dti)
        {
            return _dtiDal.Insert(dti)>0;
        }

        public bool Edit(DishTypeInfo dti)
        {
            return _dtiDal.Update(dti) > 0;

        }

        public bool Remove(int id)
        {
            return _dtiDal.Delete(id) > 0;
        }
    }
}
