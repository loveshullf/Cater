using System;
using System.Collections.Generic;
using Dal;
using Model;

namespace Bll
{
    public class MemberTypeInfoBll
    {
        private readonly MemberTypeInfoDal mtiDal = new MemberTypeInfoDal();

        public List<MemberTypeInfo> GetList()
        {
            return mtiDal.GetList();
        }

        public bool Add(MemberTypeInfo mti)
        {
            return mtiDal.Insert(mti) > 0;
        }

        public bool Edit(MemberTypeInfo mti)
        {
            return mtiDal.Update(mti) > 0;
        }

        public bool Remove(int id)
        {
            return mtiDal.Delete(id) > 0;
        }
    }
}