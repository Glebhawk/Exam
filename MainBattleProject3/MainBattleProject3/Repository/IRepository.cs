using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;
using MainBattleProject3.Stores;

namespace MainBattleProject3.Repository
{
    interface IRepository
    {
        public void AddGoodsToDb(IGoods goods, IStore store);
        public void GetStoresFromDb();
        public List<IGoods> GetGoodsFromDB();
    }
}
