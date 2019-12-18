using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.BL
{
    class DataManager
    {

        public static void Buy(Buyer buyer, int count)
        {
            //buyer.buy(seller, count);
        }

        public static List<Buyer> buyers = new List<Buyer>(); //new가 붙어야 생성이 됨

        public static bool Join(bool buyer, string id, string passwd)
        {

            if (buyers.Exists((x) => x.Id == id))
                return false;
            buyers.Add(new Buyer(id, passwd));
            return true;

        }

    }
}
