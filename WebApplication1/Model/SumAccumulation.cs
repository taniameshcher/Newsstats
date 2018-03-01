using System.Collections.Generic;

namespace WebApplication1.Model
{
    public static class SumAccumulation
    {
        #region fields

        private static int sum;
        private static Dictionary<string, CountExists> casheDictionary = new Dictionary<string, CountExists>();

        #endregion

        #region props

        public static int Sum { get => sum; set => sum = value; }
        public static Dictionary<string, CountExists> CacheDictionary { get => casheDictionary; }

        #endregion
    }
}
