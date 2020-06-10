using System;
using System.Collections.Generic;
using System.Text;

namespace MainBattleProject3.Stores
{
    interface IStore
    {
        string title { get; set; }
        List<string> allowedCategories { get; set; }
        List<string> allowedTypes { get; set; }
    }
}
