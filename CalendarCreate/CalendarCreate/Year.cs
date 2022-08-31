namespace CalendarCreate
{
    public class Year
    {
        public ushort _value { get; }
        public bool _isLeap { get; }
        public Month[] _months { get; }

        public Year(ushort value)
        {
            _value = value;
            _isLeap = IsALeapYear(value);

            _months = new Month[(ushort)Month.eMONTHS.COUNT];
            for (ushort i = 0; i < _months.Length; i++)
            {
                _months[i] = new Month(i, value, _isLeap);
            }
        }

        /**
         * Determine if a given year is a leap year.
         * 
         * \year short The decimal value of the year of interest, must be greater than 1582.
         * \return bool TRUE if the year is a leap year, else FALSE.
         */
#if TEST
        public bool IsALeapYear(ushort year)
#else
        private bool IsALeapYear(ushort year)
#endif
        {
            bool isLeap = false;

            if (year >= 1582u)
            {
                /* Simpler to determine if a year is not a leap year*/
                isLeap = true;

                /* https://en.wikipedia.org/wiki/Gregorian_calendar : 
                 * 'Every year that is exactly divisible by four is a leap year' */
                if (0u != year % 4u)
                {
                    isLeap = false;
                }
                else
                {
                    /* https://en.wikipedia.org/wiki/Gregorian_calendar : 
                     * '..except for years that are exactly divisible by 100, 
                     * but these centurial years are leap years if they are exactly divisible by 400.'*/
                    if ((0u == year % 100u) && (0u != year % 400u))
                    {
                        isLeap = false;
                    }
                }
            }

            return isLeap;
        }
    }
}
