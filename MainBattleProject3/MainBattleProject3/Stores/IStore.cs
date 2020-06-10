using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;

namespace MainBattleProject3.Stores
{
    interface IStore
    {
        string title { get; set; }
        List<string> allowedCategories { get; set; }
        List<string> allowedTypes { get; set; }

        public void PutGoodsHere(IGoods Goods);

        public List<IGoods> GetGoods();
    }
}
