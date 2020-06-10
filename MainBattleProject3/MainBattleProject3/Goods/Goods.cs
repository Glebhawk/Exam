using System;
using System.Collections.Generic;
using System.Text;

namespace MainBattleProject3.Goods
{
    class Goods : IGoods
    {
        public string title { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public double purchasePrice { get; set; }
        public double retailPrice { get; set; }
    }
}
