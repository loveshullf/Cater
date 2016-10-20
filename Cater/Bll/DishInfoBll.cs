using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class DishInfoBll
    {
        private DishInfoDal _diDal=new DishInfoDal();

        public List<DishInfo> GetList(DishInfo di)
        {
            return _diDal.GetList(di);
        }

        public bool Add(DishInfo di)
        {
            return _diDal.Insert(di) > 0;
        }

        public bool Edit(DishInfo di)
        {
            return _diDal.Update(di) > 0;
        }

        public bool Remove(int id)
        {
            return _diDal.Delete(id)>0;
        }
    }
}
