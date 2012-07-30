﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Order
{
    //每条订单详细信息;
    public class orderDetailInfo
    {
        public int OdDetlNum { get; set; }  //订单排序号;
        public string Qty { get; set; }
        public string ProDes { get; set; }
        public string tag { get; set; }
        public string listPrice { get; set; }
        public string RepPrice { get; set; }
        public string custPrice { get; set; }
        public int orderDetailInfoID { get; set; }//订单详细信息类自身唯一ID
        public int OrderDetailNo { get; set; }//订单详细信息项的排列序号；
        public int OrderInfoId { get; set; }//对应订单的ID
        public int OrderInfoType { get; set; }//1的时候选型，2的时候选图

        //选型设备ID和类型
        public int DeviceId { get; set; }
        public string DeviceType { get; set; }
    }
}
