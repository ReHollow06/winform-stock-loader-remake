using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer
{
    internal abstract class Recogniser
    {
        public string patternName { get; set; } // name of pattern that matches
        public int patternSize { get; set; } // size of pattern (in # of candlesticks) 


        public Recogniser(string patternName, int patternSize)
        {
            this.patternName = patternName;
            this.patternSize = patternSize;
        }
        /// <summary>
        /// Returns true if a subset of a list of candlesticks matches a pattern
        /// </summary>
        /// <param name="subset"></param>
        /// <returns></returns>
        protected abstract bool isPatternMatch(List<Candlestick> subset);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candlesticks"></param>
        /// <returns></returns>
        public List<int> returnIndices(List<Candlestick> candlesticks)
        {
            List<int> indices = new List<int>();

            int offset = patternSize - 1;
            
            for (int i = offset; i < candlesticks.Count; i++)
            {
                List<Candlestick> subset = candlesticks.GetRange(i - offset, patternSize);

                if (isPatternMatch(subset))
                {
                    indices.Add(i);
                }
            }

            return indices;
        }
    }

    internal class RecogniserDoji : Recogniser  
    {
        public RecogniserDoji() : base("Doji", 1) { }
        decimal dojiThreshold = 0.05m;

        /// <summary>
        /// Checks if given subset matches pattern of a doji
        /// </summary>
        /// <param name="subset"></param>
        /// <returns></returns>
        protected override bool isPatternMatch(List<Candlestick> subset)
        {
            var cs = subset[0];
            // Calculate the difference between open and close prices
            Decimal diff = Math.Abs(cs.Open - cs.Close);

            // Calculate the range between the high and low prices
            Decimal range = Math.Abs(cs.High - cs.Low);

            // Check if the difference between open and close is less than the threshold
            if (diff / range < dojiThreshold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class RecogniserBullishMarubozu : Recogniser
    {
        public RecogniserBullishMarubozu() : base("Bullish Marubozu", 1) { }
        decimal marubozuThreshold = 0.9m;

        /// <summary>
        /// Checks if given subset matches pattern of a bullish marubozu
        /// </summary>
        /// <param name="subset"></param>
        /// <returns></returns>
        protected override bool isPatternMatch(List<Candlestick> subset)
        {
            var cs = subset[0];
            var bodyLength = Math.Abs(cs.Close - cs.Open);
            var upperWickLength = cs.High - Math.Max(cs.Close, cs.Open);
            var lowerWickLength = Math.Min(cs.Close, cs.Open) - cs.Low;
            var totalLength = bodyLength + upperWickLength + lowerWickLength;

            var bodyToTotalLengthRatio = bodyLength / totalLength;

            if (bodyToTotalLengthRatio >= marubozuThreshold)
            {
                // Check if the candlestick is bullish or bearish
                if (cs.Open < cs.Close && upperWickLength <= bodyLength * 0.1m && lowerWickLength <= bodyLength * 0.1m)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    
    internal class RecogniserBearishMarubozu : Recogniser
    {
        public RecogniserBearishMarubozu() : base("Bearish Marubozu", 1) { }
        decimal marubozuThreshold = 0.9m;

        /// <summary>
        /// Checks if given subset matches pattern of a bearish marubozu
        /// </summary>
        /// <param name="subset"></param>
        /// <returns></returns>
        protected override bool isPatternMatch(List<Candlestick> subset)
        {
            var cs = subset[0];
            var bodyLength = Math.Abs(cs.Close - cs.Open);
            var upperWickLength = cs.High - Math.Max(cs.Close, cs.Open);
            var lowerWickLength = Math.Min(cs.Close, cs.Open) - cs.Low;
            var totalLength = bodyLength + upperWickLength + lowerWickLength;

            var bodyToTotalLengthRatio = bodyLength / totalLength;

            if (bodyToTotalLengthRatio >= marubozuThreshold)
            {
                // Check if the candlestick is bullish or bearish
                if (cs.Close < cs.Open && upperWickLength <= bodyLength * 0.1m && lowerWickLength <= bodyLength * 0.1m)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    internal class RecogniserBullishHammer : Recogniser
    {
        public RecogniserBullishHammer() : base("Bullish Hammer", 1) { }
        decimal hammerThreshold = 0.3m;

        /// <summary>
        /// Checks if given subset matches pattern of bullish hammer
        /// </summary>
        /// <param name="subset"></param>
        /// <returns></returns>
        protected override bool isPatternMatch(List<Candlestick> subset)
        {
            var cs = subset[0];
            var bodyLength = Math.Abs(cs.Close - cs.Open);
            var upperWickLength = cs.High - Math.Max(cs.Close, cs.Open);
            var lowerWickLength = Math.Min(cs.Close, cs.Open) - cs.Low;
            if (lowerWickLength == 0)
            {
                return false;
            }
            var totalLength = bodyLength + upperWickLength + lowerWickLength;

            var bodyToTotalLengthRatio = bodyLength / totalLength;
            var upperWickToLowerWickRatio = upperWickLength / lowerWickLength;

            if (bodyToTotalLengthRatio < hammerThreshold && upperWickLength <= bodyLength && lowerWickLength >= bodyLength)
            {
                if (cs.Close > cs.Open && upperWickToLowerWickRatio < 0.3m)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    
    internal class RecogniserBearishHammer : Recogniser
    {
        public RecogniserBearishHammer() : base("Bearish Hammer", 1) { }
        decimal hammerThreshold = 0.3m;

        /// <summary>
        /// Checks if given subset matches pattern of bearish hammer
        /// </summary>
        /// <param name="subset"></param>
        /// <returns></returns>
        protected override bool isPatternMatch(List<Candlestick> subset)
        {
            var cs = subset[0];
            var bodyLength = Math.Abs(cs.Close - cs.Open);
            var upperWickLength = cs.High - Math.Max(cs.Close, cs.Open);
            var lowerWickLength = Math.Min(cs.Close, cs.Open) - cs.Low;

            if (lowerWickLength == 0)
            {
                return false;
            }

            var totalLength = bodyLength + upperWickLength + lowerWickLength;

            var bodyToTotalLengthRatio = bodyLength / totalLength;
            var upperWickToLowerWickRatio = upperWickLength / lowerWickLength;

            if (bodyToTotalLengthRatio < hammerThreshold && upperWickLength <= bodyLength && lowerWickLength >= bodyLength)
            {
                if (cs.Close < cs.Open && upperWickToLowerWickRatio < 0.3m)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
