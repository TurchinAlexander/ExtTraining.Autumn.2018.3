using System;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfo> Notify = delegate { };
        private StockInfo stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Market()
        {
            Random rnd = new Random();
            this.stocksInfo.USD = rnd.Next(20, 40);
            this.stocksInfo.Euro = rnd.Next(30, 50);
            this.Notify(this, this.stocksInfo);
        }
    }
}
