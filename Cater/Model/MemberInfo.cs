using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MemberInfo
    {
        public int Mid { get; set; }
        public string MName { get; set; }
        public string MPhone { get; set; }
        public decimal MMoney { get; set; }
        public int MTypeId { get; set; }
        public Boolean MIsDelete { get; set; }

        //查询结果
        public string TyptTitle { get; set; }
    }
}
