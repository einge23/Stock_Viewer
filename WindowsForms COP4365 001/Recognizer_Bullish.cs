﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_COP4365_001
{
    internal class Recognizer_Bullish
    {
        bool Recognize(List<SmartCandlestick> scsList, int index)
        {
            SmartCandlestick scs = scsList[index];
            bool r =  (scs.open < scs.close);

            //check if bullish exists in the properties dictionary. If not, add it. If it does, return the key.
            if (scs.properties.ContainsKey("Bullish"))
            {
                return scs.properties["Bullish"];
            }
            else
            {
                scs.properties.Add("Bullish", r);
                return r;

            }
            
        }
        Recognizer_Bullish(){}
        


    }
}
