﻿using System;
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
            return miDal.GetList(null);
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
        public bool Login(ManagerInfo mi)
        {
           var List = miDal.GetList(mi);
            if (List.Count > 0)
            {
                mi.MType = List[0].MType;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
