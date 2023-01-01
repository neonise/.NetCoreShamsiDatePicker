using System;

namespace RMDP.Utils.Formatter.TimeUnits
{
    public class Month : AbstractTimeUnit
    {
        public Month()
        {
            MillisPerUnit = 1000L * 60L * 60L * 24L * 30L;
        }

        protected override string GetResourcePrefix()
        {
            return "Month";
        }
    }
}