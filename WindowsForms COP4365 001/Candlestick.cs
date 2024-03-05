﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_COP4365_001
{
    /// <summary>
    /// class definition for the candlestick object
    /// </summary>
    public class Candlestick
    {
        //the following lines initializes decimal attributes of a candlestick and also the getter and setter functions for them
        public decimal open {  get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }
        public decimal adj_close { get; set; }
        public ulong volume { get; set; }
        public DateTime date { get; set; }

       public Candlestick() { }

        /// <summary>
        /// This method will convert the data input from a csv file into candlesticks
        /// </summary>
        /// <param name="RowOfData">Row of Data read by the stream reader</param>
        public Candlestick(string RowOfData) 
        {
            //defines a character array of separator values for parsing the row of data
            char[] separators = new char[] { ',', '"'};

            //defines a string array 'substrings' and makes splits the row of data into multiple strings, splits by the separator values,
            //and removes empty entries.
            string[] substrings = RowOfData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //get the date string so that we can send it to DateTime.Parse
            string dateString = substrings[0];

            //the candlesticks date value is set to the date time value parsed in the dateString
            date = DateTime.Parse(dateString);

            //temp decimal value used to set the candlesticks values from the substrings.
            decimal temp;

            //boolean value set to true if temp is given a value after the substring is attempted to be parsed, false if otherwise.
            bool success  = decimal.TryParse(substrings[1], out temp);

            //if success is true the open value is set to temp, which is the output from the substring being parsed.
            if (success) open = temp;

            //this is repeated for all of the other attributes of the candlestick.

            success = decimal.TryParse(substrings[2], out temp);
            if (success) high = temp;

            success = decimal.TryParse(substrings[3], out temp);
            if (success) low = temp;

            success = decimal.TryParse(substrings[4], out temp);
            if (success) close = temp;

            success = decimal.TryParse(substrings[5], out temp);
            if (success) adj_close = temp;
            
            //does the same as the decimal temp variable but for an unsigned long value which is used for setting the volume.
            ulong tempVol;
            success = ulong.TryParse(substrings[6], out tempVol);
            if (success) volume = tempVol;

            
        }

    }
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

        SmartCandlestick(string RowOfData) : base(RowOfData)
        {
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
