using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;
using MainBattleProject3.Stores;

namespace MainBattleProject3.Managers
{
    interface IManager
    {
        public void AddGoods(string GoodsTitle, string Category, string Type, double PurchacePrice, double RetailPrice, string StoreTitle);
        public List<IStore> GetAvailableStores(string Category, string Type);
        public List<IGoods> GetAllGoods();
    }
}
