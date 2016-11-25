using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class TradeEffluent
    {

        public TradeEffluent(string tradeEffluentDischarge,
                               string description,
                               string proposedDailyVolume,
                               string proposedDailyRate,
                               string periodOfDischarge,
                               string treatment
                               )
            {
                TradeEffluentDischarge = tradeEffluentDischarge;
                Description = description;
                ProposedDailyVolume = proposedDailyVolume;
                ProposedDailyRate = proposedDailyRate;
                PeriodOfDischarge = periodOfDischarge;
                Treatment = treatment;
            }

        public TradeEffluent()
            {

            }

        public string TradeEffluentDischarge { get; set; }
        public string Description { get; set; }
        public string ProposedDailyVolume { get; set; }
        public string ProposedDailyRate { get; set; }
        public string PeriodOfDischarge { get; set; }
        public string Treatment { get; set; }
        }
    
}
