using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PastryShop.Models;

namespace PastryShop.ViewModels
{
   public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
