﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBootstrap.Models
{
    public enum QueryType
    {
        O_cd,
        P_cd
    }

    public  class QueryParams
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public string Search { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }

        public int? STime { get; set; } // 搜素开始时间
        public int? ETime { get; set; } // 搜素开始时间

        public string M_id { get; set; }    // 广告主

        public string QueryType { get; set; }    // 查询类型
        //public string O_cd { get; set; }    // 订单编号
        //public string P_cd { get; set; }    // 商品编号
        public string TypeValue { get; set; }
        
    }

    public class RespResult<T>
    {
        public int IsOk { get; set; }
        public int Count { get; set; }
        public List<T> Result { get; set; }
    }
}
