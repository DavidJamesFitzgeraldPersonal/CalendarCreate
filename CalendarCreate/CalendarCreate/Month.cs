namespace CalendarCreate
{
    public class Month
    {
        public enum eMONTHS
        {
            JANUARY = 0,
            FEBRUARY,
            MARCH,
            APRIL,
            MAY,
            JUNE,
            JULY,
            AUGUST,
            SEPTEMBER,
            OCTOBER,
            NOVEMBER,
            DECEMBER,

            COUNT
        };

        public ushort _value { get; }
        public string _name { get; }
        public Day[] _days { get; }

        public Month(ushort index, ushort year, bool isLeapYear)
        {
            _value = index;

            _name = ((eMONTHS)index).ToString();

            ushort weekDay = (ushort)Day.DetermineWeekDay(1, (ushort)(index + 1), year);

            _days = new Day[GetDaysInMonth((eMONTHS)index, isLeapYear)];
            for(ushort i = 0; i < _days.Length; i++)
            {
                _days[i] = new Day((ushort)(i+1u), (ushort)((weekDay++)%7));
            }
        }

        /**
         * Determine how many days are in a given month.
         * 
         * \month enum the month to determine.
         * \isLeapYear bool TRUE if the year is a leap year, else FALSE.
         * \return ushort Number of days in the given month. 0 if not a valid month.
         */
        private ushort GetDaysInMonth(eMONTHS month, bool isLeapYear)
        {
            ushort daysInMonth = 0;

            switch (month)
            {
                case eMONTHS.FEBRUARY:
                    daysInMonth = isLeapYear ? (ushort)29u : (ushort)28u;
                    break;

                case eMONTHS.APRIL:
                case eMONTHS.JUNE:
                case eMONTHS.SEPTEMBER:
                case eMONTHS.NOVEMBER:
                    daysInMonth = 30;
                    break;

                case eMONTHS.JANUARY:
                case eMONTHS.MARCH:
                case eMONTHS.MAY:
                case eMONTHS.JULY:
                case eMONTHS.AUGUST:
                case eMONTHS.OCTOBER:
                case eMONTHS.DECEMBER:
                    daysInMonth = 31;
                    break;

                default:
                    break;
            }
            return daysInMonth;
        }
    }
}
