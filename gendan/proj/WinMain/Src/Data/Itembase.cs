using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Src.Data
{
    class Itembase
    {
        public String name;
        public Boolean status;//true:有效，false无效
        DateTime time_start;//数据项开始创建时间
        DateTime time_end;//数据项计划结束时间

        public Itembase(String name = "NULL", Boolean status = false)
        {
            this.name = name;
            this.status = status;
        }
    }
}
