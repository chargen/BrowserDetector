﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bashmohandes.DeviceDetector.Library.Parser
{
    partial class browsersDefaultBrowser : IBrowserFileElement
    {

        public BrowserTreeNodeType NodeType
        {
            get { return BrowserTreeNodeType.DefaultBrowser; }
        }
    }
}
