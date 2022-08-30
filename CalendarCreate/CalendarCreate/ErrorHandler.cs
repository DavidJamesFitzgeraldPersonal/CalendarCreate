namespace CalendarCreate
{
    static class ErrorHandler
    {
        public enum eERRORS
        { 
            USAGE = -1,
            YEAR = -2,
            FILE_LENGTH = -3,
            FILE_NAME = -4,
            FILE_ACCESS = -5,
        };

        public static int HandleError(eERRORS type)
        {
#if !TEST
            switch(type)
            {
                case eERRORS.USAGE:
                    Console.WriteLine("USAGE ERROR: Please specify the year of interest (in decimal notation from 1582) and the required file name \r\n" +
                                        "seperated by a space. e.g. \r\n" +
                                        "1582 fileName");
                    break;

                case eERRORS.YEAR:
                    Console.WriteLine("YEAR ERROR: Please specify the year of interest in decimal notation from 1582 to " + ushort.MaxValue.ToString());
                    break;

                case eERRORS.FILE_LENGTH:
                    Console.WriteLine("FILE NAME LENGTH ERROR: Please specify a file name of less than 100 characters");
                    break;

                case eERRORS.FILE_NAME:
                    Console.WriteLine("FILE NAME ERROR: Please specify a valid file name");
                    break;

                case eERRORS.FILE_ACCESS:
                    Console.WriteLine("FILE ACCESS ERROR: File system error");
                    break;

                default:
                    Console.WriteLine("Unhandled Error!");
                    break;
            }
#endif
            return (int)type;
        }
    }
}
