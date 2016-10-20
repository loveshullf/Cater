using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class FormFactory
    {
        #region 管理界面
        private static ManagerInfoList _managerInfoList;

        public static ManagerInfoList CraeteManagerInfoList()
        {
            if (_managerInfoList == null || _managerInfoList.IsDisposed)
            {
                _managerInfoList = new ManagerInfoList();
            }
            return _managerInfoList;
        }
        #endregion
        #region 会员信息
        private static MemberInfoList _memberInfoList;

        public static MemberInfoList CreateMemberInfoList()
        {
            if (_memberInfoList == null || _memberInfoList.IsDisposed)
            {
                _memberInfoList = new MemberInfoList();
            }
            return _memberInfoList;
        }
        #endregion
        #region 会员分类信息
        private static MemberTypeInfoList _memberTypeInfoList;

        public static MemberTypeInfoList CreateMemberTypeInfoList()
        {
            if (_memberTypeInfoList == null || _memberTypeInfoList.IsDisposed)
            {
                _memberTypeInfoList = new MemberTypeInfoList();
            }
            return _memberTypeInfoList;
        }
        #endregion 
        #region 菜单分类界面
        private static DishTypeInfoList _dishTypeInfoList;

        public static DishTypeInfoList CreateDishTypeInfoList()
        {
            if (_dishTypeInfoList == null || _dishTypeInfoList.IsDisposed)
            {
                _dishTypeInfoList=new DishTypeInfoList();
            }
            return _dishTypeInfoList;
        }
        #endregion
        #region 菜单界面
        private static DishInfoList _dishInfoList;

        public static DishInfoList CreateDishInfoList()
        {
            if (_dishInfoList == null || _dishInfoList.IsDisposed)
            {
                _dishInfoList = new DishInfoList();
            }
            return _dishInfoList;
        }
        #endregion
        #region 餐桌管理
        private static TableInfoList _tableInfoList;

        public static TableInfoList CreateTableInfoList()
        {
            if (_tableInfoList == null || _tableInfoList.IsDisposed)
            {
                _tableInfoList = new TableInfoList();
            }
            return _tableInfoList;
        }
        #endregion
        #region 包厅管理
        private static HallInfoList _hallInfoList;

        public static HallInfoList CreatehHallInfoList()
        {
            if (_dishInfoList == null || _dishInfoList.IsDisposed)
            {
                _hallInfoList = new HallInfoList();
            }
            return _hallInfoList;
        }
        #endregion

    }
}