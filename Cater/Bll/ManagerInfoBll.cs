using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
    public class ManagerInfoBll
    {
        private ManagerInfoDal miDal = new ManagerInfoDal();
        public List<ManagerInfo> GetList()
        {
            ManagerInfoDal miDal = new ManagerInfoDal();
            return miDal.GetList();
        }
        public bool Add(ManagerInfo mi)
        {
           return  miDal.Insert(mi)>0;
        }

        public bool Remove(int id)
        {
            return miDal.DeleteById(id) > 0;
        }
        public bool Edit(ManagerInfo mi)
        {
            return miDal.Update(mi) > 0;
        }
    }
}
