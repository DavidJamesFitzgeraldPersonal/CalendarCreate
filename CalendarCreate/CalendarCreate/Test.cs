#if TEST
namespace CalendarCreate
{
    internal class Test
    {
        /* Constructor */
        public Test()
        {
            Console.WriteLine("TEST directive defined");
        }

        /* Public */
        public int RunAll()
        {
            Console.WriteLine(" RunAll");

            ParseUserInput_Test0_USAGE();
            ParseUserInput_Test1_USAGE();
            ParseUserInput_Test2_USAGE();
            ParseUserInput_Test3_USAGE();

            ParseUserInput_Test0_YEAR();
            ParseUserInput_Test1_YEAR();
            ParseUserInput_Test2_YEAR();
            ParseUserInput_Test3_YEAR();
            ParseUserInput_Test4_YEAR();

            ParseUserInput_Test0_FILELEN();
            ParseUserInput_Test1_FILELEN();

            ParseUserInput_Test0_FILENAME();
            ParseUserInput_Test1_FILENAME();
            return 0;
        }

        /* Private */
        #region USAGE_ERRORS
        private bool ParseUserInput_Test0_USAGE()
        {
            bool result = false;

            string[] args = new string[0];

            if(ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test0_USAGE - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test0_USAGE - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test1_USAGE()
        {
            bool result = false;

            string[] args = {"TEST"};

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test1_USAGE - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test1_USAGE - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test2_USAGE()
        {
            bool result = false;

            string[] args = { "TEST", "TEST", "TEST" };

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test2_USAGE - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test2_USAGE - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test3_USAGE()
        {
            bool result = false;

            string[] args = { "TEST", "TEST", "TEST", "TEST", "TEST", "TEST" };

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test2_USAGE - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test2_USAGE - FAIL");
            }

            return result;
        }
        #endregion
        #region YEAR_ERRORS
        private bool ParseUserInput_Test0_YEAR()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "1581";
            args[1] = "TEST";
            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test0_YEAR - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test0_YEAR - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test1_YEAR()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "0";
            args[1] = "TEST";
            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test1_YEAR - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test1_YEAR - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test2_YEAR()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "-1";
            args[1] = "TEST";
            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test2_YEAR - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test2_YEAR - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test3_YEAR()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "a";
            args[1] = "TEST";
            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test3_YEAR - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test3_YEAR - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test4_YEAR()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "FIFTEEN EIGHTY TWO";
            args[1] = "TEST";
            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test4_YEAR - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test4_YEAR - FAIL");
            }

            return result;
        }
        #endregion
        #region FILE_LENGTH ERRORS
        private bool ParseUserInput_Test0_FILELEN()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "1582";
            args[1] = "";
            if (ErrorHandler.eERRORS.FILE_LENGTH == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test0_FILELEN - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test0_FILELEN - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test1_FILELEN()
        {
            bool result = false;

            char[] fileName = new char[101];
            string[] args = new string[2];

            for (int i = 0; i < 100; i++)
            {
                fileName[i] = (char)'a';
            }

            
            args[0] = "1582";
            args[1] = new string(fileName);

            if (ErrorHandler.eERRORS.FILE_LENGTH == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test1_FILELEN - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test1_FILELEN - FAIL");
            }

            return result;
        }
        #endregion
        #region FILE_NAME ERRORS
        private bool ParseUserInput_Test0_FILENAME()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "1582";
            args[1] = "*";
            if (ErrorHandler.eERRORS.FILE_NAME == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test0_FILENAME - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test0_FILENAME - FAIL");
            }

            return result;
        }
        private bool ParseUserInput_Test1_FILENAME()
        {
            bool result = false;

            string[] args = new string[2];
            args[0] = "1582";
            args[1] = "?";
            if (ErrorHandler.eERRORS.FILE_NAME == (ErrorHandler.eERRORS)Program.ParseUserInput(args))
            {
                Console.WriteLine("     ParseUserInput_Test1_FILENAME - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     ParseUserInput_Test1_FILENAME - FAIL");
            }

            return result;
        }
        #endregion
    }
}
#endif
