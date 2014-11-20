using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CreditScore.Models
{
    public class CreditScoreTotalsDataContext
    {
        //public DbSet<CreditScoreTotals> CreditScoreTotals { get; set; }

        private List<CreditScoreTotals> privateTotals = new List<CreditScoreTotals>();

        public CreditScoreTotalsDataContext()
        {
            Random myRandom = new Random();
            for(int i = 0; i<50; i++)
            {
                
                privateTotals.Add( new CreditScoreTotals{
                SearchKey = new Guid(),
                RequestDate = (DateTime)DateGeneration(),
                CreditScore = myRandom.Next(5)
            });
            }
        }

        public List<CreditScoreTotals> CreditScoreTotals {
        get {return privateTotals;}
    }

        private DateTime DateGeneration()
        {
            DateTime start = new DateTime(2000, 1,3);
            Random gen = new Random();
            return start.AddDays(gen.Next(3));

        }
           

    
     

    }
}