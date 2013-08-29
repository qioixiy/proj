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

        public Itembase(String name = "NULL", Boolean status = false)
        {
            this.name = name;
            this.status = status;
        }
    }
}
