using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class HallInfoBll
    {
        private HallInfoDal _hiDal = new HallInfoDal();

        public List<HallInfo> GetList()
        {
            return _hiDal.GetList();
        }

        public bool Add(HallInfo hi)
        {
            return _hiDal.Insert(hi)>0;
        }

        public bool Edit(HallInfo hi)
        {
            return _hiDal.Update(hi) > 0;
        }

        public bool Remove(int id)
        {
            return _hiDal.Delete(id) > 0;
        }
    }
}