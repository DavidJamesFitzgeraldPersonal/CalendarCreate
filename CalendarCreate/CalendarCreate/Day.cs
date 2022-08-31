using System;

namespace CalendarCreate
{
    public class Day
    {
        public enum eWEEKDAY
        {
            SATURDAY = 0,
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,

            COUNT
        };

        public ushort _value { get; }
        public eWEEKDAY _name { get; }

        public Day(ushort value, ushort day)
        {
            _value = value;
            _name = (eWEEKDAY)day;
        }

        /**
        * Determine the weekday based on given day index, month index and year.
        * 
        * \day ushort the day of the month.
        * \month ushort the month of the year, 1 = JANUARY etc.
        * \yearh ushort the year.
        * \return eWEEKDAY enum of weekday for the given day, month, year.
        */
        public static eWEEKDAY DetermineWeekDay(ushort day, ushort month, ushort year)
        {
            /* Determine the week-day using ISO8601 Zellers Congruence https://en.wikipedia.org/wiki/Zeller's_congruence */
            /* day = (day_of_month) + floor((13*(month+1))/5) + (year%100) + floor((year%100)/4) + floor((floor(year/100))/4) - (2*((floor(year/100)))*/

            int q = day;
            int m = month;
            int y = year;

            if (1 == m)
            {
                m = 13;
                y--;
            }

            if (2 == m)
            {
                m = 14;
                y--;
            }

            int K = y % 100;
            int J = y / 100;

            int weekDay = ((q + (int)((13 * (m + 1)) / 5) + K + ((int)(K / 4)) + ((int)(J / 4)) - (2 * J)) % 7);

            if(weekDay < 0)
            {
                weekDay += (int)eWEEKDAY.COUNT;
            }

            return (eWEEKDAY)weekDay;
        }
    }
}
