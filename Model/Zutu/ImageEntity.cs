﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Model.Zutu
{
    [Serializable]
    public class ImageEntity
    {
        /// <summary>
        /// 图块名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 图块矩形区域
        /// </summary>
        public Rectangle Rect { get; set; }
        /// <summary>
        /// 图块对应url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 图块对应类型
        /// </summary>
        public string Type { get; set; }

        public string Text
        {
            set;
            get;
        }

        public bool HitTest(Point point)
        {
            Region region = new Region(Rect);
            if (region.IsVisible(point))
                return true;
            return false;
        }
    }
}