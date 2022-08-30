namespace CalendarCreate
{
    public class Calendar
    {
        public Year[] _years { get; set; }

        public Calendar(ushort year)
        {
            /*TODO how to handle years before 1582*/
            if (year >= 1583)
            {
                _years = new Year[3];

                _years[0] = new Year((ushort)(year - 1));
                _years[1] = new Year(year );
                _years[2] = new Year((ushort)(year + 1));
            }
        }
    }
}
