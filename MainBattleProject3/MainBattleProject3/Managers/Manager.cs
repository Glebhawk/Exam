using System;
using System.Collections.Generic;
using System.Text;
using MainBattleProject3.Goods;
using MainBattleProject3.Stores;
using MainBattleProject3.Repository;
using MainBattleProject3.IoC;

namespace MainBattleProject3.Managers
{
    class Manager : IManager
    {
        private IRepository repository { get; set; }

        public Manager()
        {
            List<object> emptyList = new List<object>();
            repository = IoCContainer.ResolveObject(typeof(IRepository), emptyList);
        }
        public void AddGoods(string GoodsTitle, string Category, string Type, double PurchacePrice, double RetailPrice, string StoreTitle)
        {
            List<object> goodsParameters = new List<object> { GoodsTitle, Category, Type, PurchacePrice, RetailPrice };
            IGoods goods = IoCContainer.ResolveObject(typeof(IGoods), goodsParameters);
            List<IStore> availableStores = GetAvailableStores(Category, Type);
            foreach(IStore store in availableStores)
            {
                if (store.title == StoreTitle)
                {
                    repository.AddGoodsToDb(goods, store);
                    store.PutGoodsHere(goods);
                }
            }
        }
        public List<IStore> GetAvailableStores(string Category, string Type)
        {
            List<IStore> stores = repository.GetStoresFromDb();
            List<IStore> availableStores = new List<IStore>();
            foreach (IStore store in stores)
            {
                if(store.allowedCategories.Contains(Category) && store.allowedTypes.Contains(Type))
                {
                    availableStores.Add(store);
                }
            }
            return availableStores;
        }
        public List<IGoods> GetAllGoods()
        {
            return repository.GetGoodsFromDB();
        }
    }
}
