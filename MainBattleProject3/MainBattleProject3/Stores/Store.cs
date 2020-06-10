using System;
using System.Collections.Generic;
using System.Text;

namespace MainBattleProject3.Stores
{
    class Store : IStore
    {
        public string title { get; set; }
        public List<string> allowedCategories { get; set; }
        public List<string> allowedTypes { get; set; }
    }
}
