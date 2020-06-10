using System;
using System.Collections.Generic;
using System.Text;

namespace MainBattleProject3.Goods
{
    interface IGoods
    {
        string title { get; set; }
        string category { get; set; }
        string type { get; set; }
        double purchasePrice { get; set; }
        double retailPrice { get; set; }
    }
}
