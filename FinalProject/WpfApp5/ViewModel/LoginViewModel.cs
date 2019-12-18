using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.BL;

namespace WpfApp5.ViewModel
{
    class LogInViewModel : Notifier
    {
        private int count;

        /*public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public Buyer MyBuyer { get; set; }
        private Seller myseller;

        public Seller MySeller
        {
            get { return myseller; }
            set
            {
                myseller = value;
                OnPropertyChanged("MySeller");
            }
        }

        public ObservableCollection<Seller> Sellers { get; set; }

        public Command BuyCommand { get; set; }

        public LogInViewModel()
        {
            Sellers = DataManager.ShowAllSellers();
            BuyCommand = new Command(executeBuy, canexecuteBuy);
        }

        private bool canexecuteBuy(object arg)
        {
            return true;
        }

        private void executeBuy(object obj)
        {
            DataManager.Buy(MyBuyer, MySeller, Count);
        }*/
    }
}
