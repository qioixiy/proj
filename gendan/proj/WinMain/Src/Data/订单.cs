using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Src.Data
{
    class 订单
    {
        public Itembase 款式图 = new Itembase("款式图");
        public Itembase 订单编号 = new Itembase("订单编号");
        public Itembase 订单分类 = new Itembase("订单分类");
        public Itembase 订单季节 = new Itembase("订单季节");
        public Itembase 客户 = new Itembase("客户");
        public Itembase 系列名称 = new Itembase("系列名称");
        public Itembase 款号_客户订单号 = new Itembase("款号_客户订单号");
        public Itembase 品名 = new Itembase("品名");
        public Itembase 订单数量 = new Itembase("订单数量");
        public Itembase 客户交期 = new Itembase("客户交期");
        public Itembase 收到资料日期 = new Itembase("收到资料日期");
        public Itembase 客户下单日期 = new Itembase("客户下单日期");
        public Itembase 建立日期 = new Itembase("建立日期");
        public Itembase 更新日期 = new Itembase("更新日期");
    }
}
