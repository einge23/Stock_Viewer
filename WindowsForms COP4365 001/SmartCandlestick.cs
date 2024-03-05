using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_COP4365_001
{
    public class SmartCandlestick : Candlestick
    {
        public decimal range { get; set; }
        public decimal topPrice { get; set; }
        public decimal bottomPrice { get; set; }
        public decimal bodyRange { get; set; }
        public decimal upperTail { get; set; }
        public decimal lowerTail { get; set; }

        public bool isBullish { get; set; }
        public bool isBearish { get; set; }
        public bool isNeutral { get; set; }
        public bool isDoji { get; set; }
        public bool isHammer { get; set; }
        public bool isMarubozu { get; set; }

        SmartCandlestick(Candlestick cs)
        {
            date = cs.date;
            open = cs.open;
            close = cs.close;
            high = cs.high;
            low = cs.low;
            adj_close = cs.adj_close;
            volume = cs.volume;



            ComputeExtraProperties();
            ComputePatternProperties();
        }

        public void ComputeExtraProperties()
        {
            range = high - low;
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            bodyRange = topPrice - bottomPrice;
            upperTail = high - topPrice;
            lowerTail = bottomPrice - low;
        }



        public void ComputePatternProperties()
        {
            isBearish = (open > close);
            isBullish = (open < close);
            isNeutral = (close == open);
            isMarubozu = (bodyRange >= (decimal)0.96 * range);
            isHammer = ((lowerTail >= (decimal)0.7 * range) || (upperTail >= (decimal)0.7 * range));
            isDoji = (bodyRange <= (decimal)0.1 * range);

        }

    }
}

