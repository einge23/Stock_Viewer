using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_COP4365_001
{
    internal class Recognizer_Bearish
    {
        bool Recognize(List<SmartCandlestick> scsList, int index)
        {
            SmartCandlestick scs = scsList[index];
            bool r = (scs.open > scs.close);

            //check if bullish exists in the properties dictionary. If not, add it. If it does, return the key.
            if (scs.properties.ContainsKey("Bearish"))
            {
                return scs.properties["Bearish"];
            }
            else
            {
                scs.properties.Add("Bearish", r);
                return r;

            }

        }
        Recognizer_Bearish() { }



    }
}
