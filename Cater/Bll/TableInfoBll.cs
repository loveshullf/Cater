using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class TableInfoBll
    {
        private readonly TableInfoDal _tiDal=new TableInfoDal();

        public List<TableInfo> GetList(TableInfo ti)
        {
            return _tiDal.GetList(ti);
        }

        public bool Add(TableInfo ti)
        {
            return _tiDal.Insert(ti) > 0;
        }

        public bool Edit(TableInfo ti)
        {
            return _tiDal.Update(ti) > 0;
        }

        public bool Remove(int id)
        {
            return _tiDal.Delete(id) > 0;
        }
    }
}
