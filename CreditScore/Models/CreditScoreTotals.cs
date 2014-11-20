using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditScore.Models
{
    public class CreditScoreTotals
    {
        public Guid SearchKey { get; set; }
        public DateTime RequestDate { get; set; }
        public int CreditScore { get; set; }
    }
}