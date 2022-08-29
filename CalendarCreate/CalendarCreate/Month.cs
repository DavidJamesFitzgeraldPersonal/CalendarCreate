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
        public int[] _days { get; }

        public Month(ushort index, bool isLeapYear)
        {
            _value = index;

            _name = ((eMONTHS)index).ToString();

            _days = new int[GetDaysInMonth((eMONTHS)index, isLeapYear)];
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
