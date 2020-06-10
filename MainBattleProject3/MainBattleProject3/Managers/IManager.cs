using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;
using MainBattleProject3.Stores;
using MainBattleProject3.Repository;

namespace MainBattleProject3.Managers
{
    interface IManager
    {
        List<IGoods> goods { get; set; }
        IRepository repository { get; set; }
        public void AddGoods(string GoodsTitle, string Category, string Type, double PurchacePrice, double RetailPrice, string StoreTitle);
        public List<IStore> GetAvailableStores(string Category, string Type);
        public void GetAllGoods();
    }
}
