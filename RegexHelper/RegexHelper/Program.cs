using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace RegexHelper
{
    class Program
    {
        static void Main()
        {
            var data =
           JsonSerializer.Deserialize<IEnumerable<tick>>("[ { \"symbol\": \"btc_usdc\", \"lastPrice\": 65689.7, \"volume\": 5507.43, \"targetVolume\": 361781424.471, \"high\": 66567.6, \"low\": 64642.4 }, { \"symbol\": \"ctn_usdc\", \"lastPrice\": 0.0427, \"volume\": 541695.47, \"targetVolume\": 23130.396569, \"high\": 0.0437, \"low\": 0.0406 }, { \"symbol\": \"eth_usdc\", \"lastPrice\": 3306.4, \"volume\": 5311.17, \"targetVolume\": 17560852.488, \"high\": 3357.1, \"low\": 3248.1 }, { \"symbol\": \"ltc_usdc\", \"lastPrice\": 100.35, \"volume\": 15803.15, \"targetVolume\": 1585846.1025, \"high\": 108.97, \"low\": 100.28 }, { \"symbol\": \"xcb_ctn\", \"lastPrice\": 4.37, \"volume\": 539125.01, \"targetVolume\": 2355976.2937, \"high\": 4.65, \"low\": 4.34 }, { \"symbol\": \"xcb_usdc\", \"lastPrice\": 0.1839, \"volume\": 533685.79, \"targetVolume\": 98144.816781, \"high\": 0.1912, \"low\": 0.177 } ]");
            var markets = new string[] { "xcb_btc", "xcb_eth", "ltc_eth", "xcb_ltc", "ctn_eth", "btc_ltc", "xcb_ctn", "xcb_usdt", "btc_usdt", "ctn_usdt", "eth_usdt", "ltc_usdt", "ltc_usdc", "xcb_usdc", "ctn_ltc", "ctn_btc", "ctn_usdc", "btc_usdc", "btc_eth", "eth_usdc" };
            var notExisting = markets.Except(
                markets.Where(x => data.FirstOrDefault(c=> c.symbol== x)!= null)
                .ToArray()).ToList();
        }
    }

    public class tick
    {
        public string symbol { get; set; }
        public decimal lastPrice { get; set; }
        public decimal volume { get; set; }
        public decimal targetVolume { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
    }
}


