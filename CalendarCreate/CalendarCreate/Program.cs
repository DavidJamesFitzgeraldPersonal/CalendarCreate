namespace CalendarCreate
{
    class Program
    {
        static int Main(string[] args)
        {
            const int FILE_NAME_MAX_LENGTH = 100;
            int status = 0;

            if (2 != args.Length)
            {
                status = ErrorHandler.HandleError(ErrorHandler.eERRORS.USAGE);
            }
            else
            {
                /* Ensure the year entered is in a usable range - Top End ?*/
                int tempYear = 0;
                if ((false == int.TryParse(args[0], out tempYear)) || (tempYear < 1582))
                {
                    status = ErrorHandler.HandleError(ErrorHandler.eERRORS.YEAR);
                }

                /* Ensure the length of the filename is sensible - This is an abitrary limit! */
                if (args[1].Length > FILE_NAME_MAX_LENGTH)
                {
                    status = ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_LENGTH);
                }

                /* Ensure the file name entered is formatted correctly*/
                char[] badFileChars = System.IO.Path.GetInvalidFileNameChars();
                foreach (char c in badFileChars)
                {
                    if (args[1].Contains(c))
                    {
                        status = ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_NAME);
                        break;
                    }
                }

            } //if (2 != args.Length)
            return status;
        }
    }
}