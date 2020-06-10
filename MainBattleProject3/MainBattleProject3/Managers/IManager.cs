using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;
using MainBattleProject3.Stores;

namespace MainBattleProject3.Managers
{
    interface IManager
    {
        public void AddGoods(IGoods goods, IStore store);
        public IStore GetAvailableStores(IGoods goods);
        public List<IGoods> GetAllGoods();
    }
}
