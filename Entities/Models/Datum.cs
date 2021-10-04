using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
 public class Datum
  {
    public int id { get; set; }
    public string name { get; set; }
    public string symbol { get; set; }
    public string slug { get; set; }
    public int num_market_pairs { get; set; }
    public DateTime date_added { get; set; }
    //public List<string> tags { get; set; }
    public long? max_supply { get; set; }
    public double circulating_supply { get; set; }
    public double total_supply { get; set; }
    public Platform platform { get; set; }
    public int cmc_rank { get; set; }
    public DateTime last_updated { get; set; }
    public Quote quote { get; set; }
  }
}
