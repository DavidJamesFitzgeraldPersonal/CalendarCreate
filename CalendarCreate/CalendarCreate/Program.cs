﻿namespace CalendarCreate
{
    class Program
    {
        const int FILE_NAME_MAX_LENGTH = 100; /*TODO - Move me to a file handler class*/
        const int LOWEST_DATE_ALLOWABLE = 1582;

        static int Main(string[] args)
        {
            
            int status = 0;

#if TEST
            Test testRunner = new Test();
            testRunner.RunAll();
#else
            status = ParseUserInput(args);
#endif
            return status;
        }

        /**
         * Determine if the user input is valid for the program.
         * 
         * \args array of user input strings. The program expects two inputs, a decimal year greater than 1582
         *      and a file name of less than 100 characters.
         * \return int 0 if valid input, else NOT 0.
         */
#if TEST
        public static int ParseUserInput(string[] args)
#else
        private static int ParseUserInput(string[] args)
#endif
        {
            if ((null == args) || (2u != args.Length))
            {
                return ErrorHandler.HandleError(ErrorHandler.eERRORS.USAGE);
            }
            else
            {
                /* Ensure the year entered is in a usable range - Top End ?*/
                int tempYear = 0;
                if ((false == int.TryParse(args[0], out tempYear)) || (tempYear < LOWEST_DATE_ALLOWABLE))
                {
                    return ErrorHandler.HandleError(ErrorHandler.eERRORS.YEAR);
                }

                /* Ensure the length of the filename is sensible - This is an abitrary limit! */
                if ((args[1].Length > FILE_NAME_MAX_LENGTH) || (args[1].Length <= 0u))
                {
                    return ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_LENGTH);
                }

                /* Ensure the file name entered is formatted correctly*/
                char[] badFileChars = System.IO.Path.GetInvalidFileNameChars();
                foreach (char c in badFileChars)
                {
                    if (args[1].Contains(c))
                    {
                        return ErrorHandler.HandleError(ErrorHandler.eERRORS.FILE_NAME);
                    }
                }
            } //if (2 != args.Length)
            
            return 0;
        }
    }
}