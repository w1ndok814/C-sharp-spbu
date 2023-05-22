﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    [Serializable] public class ViewSettings
    {
        public string BackgroundColor { get;  set; }
        public int FontSize { get;  set; }
        public string ButtonColor { get;  set; }
        public ViewSettings()
        {

        }
    }
}
