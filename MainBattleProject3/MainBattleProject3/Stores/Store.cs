using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;

namespace MainBattleProject3.Stores
{
    class Store : IStore
    {
        public string title { get; set; }
        public List<string> allowedCategories { get; set; }
        public List<string> allowedTypes { get; set; }
        public List<IGoods> goods { get; set; } = new List<IGoods>();

        public Store(string Title, List<string> AllowedCategories, List<string> AllowedTypes)
        {
            title = Title;
            allowedCategories = AllowedCategories;
            allowedTypes = AllowedTypes;
        }

        public void PutGoodsHere(IGoods Goods)
        {
            goods.Add(Goods);
        }

        public List<IGoods> GetGoods()
        {
            return goods;
        }
    }
}
