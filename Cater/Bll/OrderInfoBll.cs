﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class OrderInfoBll
    {
        private OrderInfoDal _oiDal=new OrderInfoDal();

        public bool KaiDan(int tableId)
        {
            return _oiDal.KaiDan(tableId) > 0;
        }

        public int GetOIdByTId(int tableid)
        {
            return _oiDal.GetOidByTId(tableid);
        }

        public bool DianCai(int orderid,int dishid)
        {
            return _oiDal.DianCai(orderid, dishid) > 0;
        }
        public List<OrderDetailInfo> GetDetailList(int orderid)
        {
            return _oiDal.GetDetaillist(orderid);
        }

        public bool UpdateDishCount(int oid, int count)
        {
            return _oiDal.UpdateDishCount(oid,count) > 0;
        }

        public bool DeleteDish(int oid)
        {
            return _oiDal.DeleteDish(oid) > 0;
        }

        public bool XiaDan(int orderid, decimal totalmoney)
        {
            return _oiDal.XiaDan(orderid, totalmoney) > 0;
        }

        public decimal GetMoneyByTId(int tablid)
        {
            return _oiDal.GetMoneyByTId(tablid);
        }

        public bool JieZhang(int tableid, int memberid, decimal discount, decimal paymoney)
        {
            return _oiDal.JieZhang(tableid, memberid, discount, paymoney) > 0;
        }
    }
}
