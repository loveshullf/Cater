using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
namespace UI
{///
    public class FormFactory
    {
        private static ManagerInfoList _managerInfoList;

        public static ManagerInfoList CraeteManagerInfoList()
        {
            if (_managerInfoList == null || _managerInfoList.IsDisposed)
            {
                _managerInfoList = new ManagerInfoList();
            }
            return _managerInfoList;
        }

        private static MemberInfoList _memberInfoList;

        public static MemberInfoList CreateMemberInfoList()
        {
            if (_memberInfoList == null || _memberInfoList.IsDisposed)
            {
                _memberInfoList = new MemberInfoList();
            }
            return _memberInfoList;
        }

        private static MemberTypeInfoList _memberTypeInfoList;

        public static MemberTypeInfoList CreateMemberTypeInfoList()
        {
            if (_memberTypeInfoList == null || _memberTypeInfoList.IsDisposed)
            {
                _memberTypeInfoList = new MemberTypeInfoList();
            }
            return _memberTypeInfoList;
        }
    }
}