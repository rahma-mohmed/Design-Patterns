using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Private constructor , public static propority
namespace Singleton
{
    public class CurrencyConvertor
    {
        private IEnumerable<ExchangeRate> _exchangeRate;

        private CurrencyConvertor()
        {
            LoadExchange();
        }

        private static CurrencyConvertor _instance;

        private static object _locker = new();

        public static CurrencyConvertor Instance
        {
            get{
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new();
                    }
                    return _instance;
                }
            }
        }

        private void LoadExchange()
        {
            Thread.Sleep(3000);

            _exchangeRate = new[]
            {
                new ExchangeRate("USD" , "SAR" , 3.75m),
                new ExchangeRate("USD" , "EGP" , 30.60m),
                new ExchangeRate("SAR" , "EGP" , 8.16m)
            };
        }

        public decimal Covert(string baseCurrency , string targetCurrency ,decimal amount)
        {
            var res = _exchangeRate.FirstOrDefault(r => r.BaseCurrency == baseCurrency && r.TargetCurrency == targetCurrency);
            return amount * res.Rate;
        }
    }
}
