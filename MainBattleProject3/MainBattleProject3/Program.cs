using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainBattleProject3.IoC;
using MainBattleProject3.Goods;
using MainBattleProject3.Managers;
using MainBattleProject3.Repository;
using MainBattleProject3.Stores;

namespace MainBattleProject3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IoCContainer.RegisterObject<IGoods, Goods.Goods>();
            IoCContainer.RegisterObject<IManager, Manager>();
            IoCContainer.RegisterObject<IStore, Store>();

            Application.Run(new Form1());
        }
    }
}
