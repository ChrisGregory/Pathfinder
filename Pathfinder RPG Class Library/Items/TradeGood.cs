﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Items
{
    class TradeGood : Item
    {
        public override Currency SellValue {get { return BuyValue; }}
    }
}
