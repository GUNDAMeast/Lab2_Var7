using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMV_Lab2_Var7
{
    public class DayTime
    {

        public int Seconds { get; private set; }

        public static int Normalize(int s)
        {
            int day = 24 * 3600;
            s %= day;
            if (s < 0) s += day;
            return s;
        }

        public DayTime(int seconds)
        {
            Seconds = ((seconds % 86400) + 86400) % 86400;
        }

        public DayTime(int hour, int minute, int second)
        : this(hour * 3600 + minute * 60 + second)
        {
        }

        public int Hour => Seconds / 3600;

        public int Minute => (Seconds % 3600) / 60;

        public int Second => (Seconds % 60);

        public int HoursPassed => Seconds / 3600;
        public int MinutesPassed => (Seconds % 3600) / 60;
        public int SecondsPassed => Seconds % 60;


        public override string ToString()
        {
            return $"{Hour}:{Minute:D2}:{Second:D2}";
        }
    }
}
