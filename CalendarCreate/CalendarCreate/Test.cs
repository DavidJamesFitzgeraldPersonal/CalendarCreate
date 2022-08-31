#if TEST
namespace CalendarCreate
{
    class Test
    {
        public Test()
        {
            Console.WriteLine("TEST directive defined");
        }

        #region PUBLIC
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

            IsALeapYear_Test0();
            IsALeapYear_Test1();
            IsALeapYear_Test2();

            YearCon_Test0();
            YearCon_Test1();

            DetermineWeekDay_Test0_MONDAY();
            DetermineWeekDay_Test1_TUESDAY();
            DetermineWeekDay_Test2_WEDNESDAY();
            DetermineWeekDay_Test3_THURSDAY();
            DetermineWeekDay_Test4_FRIDAY();
            DetermineWeekDay_Test5_SATURDAY();
            DetermineWeekDay_Test6_SUNDAY();
            return 0;
        }
        #endregion

        #region PRIVATE
        #region USAGE_ERRORS
        private bool ParseUserInput_Test0_USAGE()
        {
            bool result = false;

            string[] args = new string[0];

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            string[] args = { "TEST" };

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.USAGE == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.YEAR  == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.YEAR == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.FILE_LENGTH == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            char[] longFileName = new char[101];
            string[] args = new string[2];

            for (int i = 0; i < 100; i++)
            {
                longFileName[i] = (char)'a';
            }

            args[0] = "1582";
            args[1] = new string(longFileName);

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.FILE_LENGTH == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.FILE_NAME == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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

            ushort year = 0;
            string fileName = "";

            if (ErrorHandler.eERRORS.FILE_NAME == (ErrorHandler.eERRORS)Program.ParseUserInput(args, out year, out fileName))
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
        #region LEAP YEAR
        private bool IsALeapYear_Test0()
        {
            bool result = false;

            Year temp = new Year(1581);

            if (!temp._isLeap)
            {
                Console.WriteLine("     IsALeapYear_Test0 - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     IsALeapYear_Test0 - FAIL");
            }

            return result;
        }
        private bool IsALeapYear_Test1()
        {
            bool result = false;

            /* Leap years from 1582 to 3000, taken from https://miniwebtool.com/leap-years-list/?start_year=1582&end_year=3000 */
            ushort[] leapYears = new ushort[] {   1584, 1588, 1592, 1596, 1600, 1604, 1608, 1612, 1616, 1620, 1624, 1628, 1632,
                                            1636, 1640, 1644, 1648, 1652, 1656, 1660, 1664, 1668, 1672, 1676, 1680, 1684, 1688,
                                            1692, 1696, 1704, 1708, 1712, 1716, 1720, 1724, 1728, 1732, 1736, 1740, 1744, 1748,
                                            1752, 1756, 1760, 1764, 1768, 1772, 1776, 1780, 1784, 1788, 1792, 1796, 1804, 1808,
                                            1812, 1816, 1820, 1824, 1828, 1832, 1836, 1840, 1844, 1848, 1852, 1856, 1860, 1864,
                                            1868, 1872, 1876, 1880, 1884, 1888, 1892, 1896, 1904, 1908, 1912, 1916, 1920, 1924,
                                            1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980,
                                            1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036,
                                            2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092,
                                            2096, 2104, 2108, 2112, 2116, 2120, 2124, 2128, 2132, 2136, 2140, 2144, 2148, 2152,
                                            2156, 2160, 2164, 2168, 2172, 2176, 2180, 2184, 2188, 2192, 2196, 2204, 2208, 2212,
                                            2216, 2220, 2224, 2228, 2232, 2236, 2240, 2244, 2248, 2252, 2256, 2260, 2264, 2268,
                                            2272, 2276, 2280, 2284, 2288, 2292, 2296, 2304, 2308, 2312, 2316, 2320, 2324, 2328,
                                            2332, 2336, 2340, 2344, 2348, 2352, 2356, 2360, 2364, 2368, 2372, 2376, 2380, 2384,
                                            2388, 2392, 2396, 2400, 2404, 2408, 2412, 2416, 2420, 2424, 2428, 2432, 2436, 2440,
                                            2444, 2448, 2452, 2456, 2460, 2464, 2468, 2472, 2476, 2480, 2484, 2488, 2492, 2496,
                                            2504, 2508, 2512, 2516, 2520, 2524, 2528, 2532, 2536, 2540, 2544, 2548, 2552, 2556,
                                            2560, 2564, 2568, 2572, 2576, 2580, 2584, 2588, 2592, 2596, 2604, 2608, 2612, 2616,
                                            2620, 2624, 2628, 2632, 2636, 2640, 2644, 2648, 2652, 2656, 2660, 2664, 2668, 2672,
                                            2676, 2680, 2684, 2688, 2692, 2696, 2704, 2708, 2712, 2716, 2720, 2724, 2728, 2732,
                                            2736, 2740, 2744, 2748, 2752, 2756, 2760, 2764, 2768, 2772, 2776, 2780, 2784, 2788,
                                            2792, 2796, 2800, 2804, 2808, 2812, 2816, 2820, 2824, 2828, 2832, 2836, 2840, 2844,
                                            2848, 2852, 2856, 2860, 2864, 2868, 2872, 2876, 2880, 2884, 2888, 2892, 2896, 2904,
                                            2908, 2912, 2916, 2920, 2924, 2928, 2932, 2936, 2940, 2944, 2948, 2952, 2956, 2960,
                                            2964, 2968, 2972, 2976, 2980, 2984, 2988, 2992, 2996 };

            foreach (ushort year in leapYears)
            {
                Year temp = new Year(year);
                if (temp._isLeap)
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine("     IsALeapYear_Test1 - FAIL at " + temp._value.ToString());
                    result = false;
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("     IsALeapYear_Test1 - PASS");
            }

            return result;
        }
        private bool IsALeapYear_Test2()
        {
            bool result = false;

            /* Leap years from 1582 to 3000, taken from https://miniwebtool.com/leap-years-list/?start_year=1582&end_year=3000 */
            ushort[] leapYears = new ushort[] {   1584, 1588, 1592, 1596, 1600, 1604, 1608, 1612, 1616, 1620, 1624, 1628, 1632,
                                            1636, 1640, 1644, 1648, 1652, 1656, 1660, 1664, 1668, 1672, 1676, 1680, 1684, 1688,
                                            1692, 1696, 1704, 1708, 1712, 1716, 1720, 1724, 1728, 1732, 1736, 1740, 1744, 1748,
                                            1752, 1756, 1760, 1764, 1768, 1772, 1776, 1780, 1784, 1788, 1792, 1796, 1804, 1808,
                                            1812, 1816, 1820, 1824, 1828, 1832, 1836, 1840, 1844, 1848, 1852, 1856, 1860, 1864,
                                            1868, 1872, 1876, 1880, 1884, 1888, 1892, 1896, 1904, 1908, 1912, 1916, 1920, 1924,
                                            1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980,
                                            1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036,
                                            2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092,
                                            2096, 2104, 2108, 2112, 2116, 2120, 2124, 2128, 2132, 2136, 2140, 2144, 2148, 2152,
                                            2156, 2160, 2164, 2168, 2172, 2176, 2180, 2184, 2188, 2192, 2196, 2204, 2208, 2212,
                                            2216, 2220, 2224, 2228, 2232, 2236, 2240, 2244, 2248, 2252, 2256, 2260, 2264, 2268,
                                            2272, 2276, 2280, 2284, 2288, 2292, 2296, 2304, 2308, 2312, 2316, 2320, 2324, 2328,
                                            2332, 2336, 2340, 2344, 2348, 2352, 2356, 2360, 2364, 2368, 2372, 2376, 2380, 2384,
                                            2388, 2392, 2396, 2400, 2404, 2408, 2412, 2416, 2420, 2424, 2428, 2432, 2436, 2440,
                                            2444, 2448, 2452, 2456, 2460, 2464, 2468, 2472, 2476, 2480, 2484, 2488, 2492, 2496,
                                            2504, 2508, 2512, 2516, 2520, 2524, 2528, 2532, 2536, 2540, 2544, 2548, 2552, 2556,
                                            2560, 2564, 2568, 2572, 2576, 2580, 2584, 2588, 2592, 2596, 2604, 2608, 2612, 2616,
                                            2620, 2624, 2628, 2632, 2636, 2640, 2644, 2648, 2652, 2656, 2660, 2664, 2668, 2672,
                                            2676, 2680, 2684, 2688, 2692, 2696, 2704, 2708, 2712, 2716, 2720, 2724, 2728, 2732,
                                            2736, 2740, 2744, 2748, 2752, 2756, 2760, 2764, 2768, 2772, 2776, 2780, 2784, 2788,
                                            2792, 2796, 2800, 2804, 2808, 2812, 2816, 2820, 2824, 2828, 2832, 2836, 2840, 2844,
                                            2848, 2852, 2856, 2860, 2864, 2868, 2872, 2876, 2880, 2884, 2888, 2892, 2896, 2904,
                                            2908, 2912, 2916, 2920, 2924, 2928, 2932, 2936, 2940, 2944, 2948, 2952, 2956, 2960,
                                            2964, 2968, 2972, 2976, 2980, 2984, 2988, 2992, 2996 };

            foreach (ushort year in leapYears)
            {
                Year temp = new Year((ushort)(year + 1u));
                if (!temp._isLeap)
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine("     IsALeapYear_Test2 - FAIL at " + temp._value.ToString());
                    result = false;
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("     IsALeapYear_Test2 - PASS");
            }

            return result;
        }
        #endregion
        #region YEAR CONSTRUCTOR
        private bool YearCon_Test0()
        {
            bool result = false;

            /* Leap years from 1582 to 3000, taken from https://miniwebtool.com/leap-years-list/?start_year=1582&end_year=3000 */
            ushort[] leapYears = new ushort[] {   1584, 1588, 1592, 1596, 1600, 1604, 1608, 1612, 1616, 1620, 1624, 1628, 1632,
                                            1636, 1640, 1644, 1648, 1652, 1656, 1660, 1664, 1668, 1672, 1676, 1680, 1684, 1688,
                                            1692, 1696, 1704, 1708, 1712, 1716, 1720, 1724, 1728, 1732, 1736, 1740, 1744, 1748,
                                            1752, 1756, 1760, 1764, 1768, 1772, 1776, 1780, 1784, 1788, 1792, 1796, 1804, 1808,
                                            1812, 1816, 1820, 1824, 1828, 1832, 1836, 1840, 1844, 1848, 1852, 1856, 1860, 1864,
                                            1868, 1872, 1876, 1880, 1884, 1888, 1892, 1896, 1904, 1908, 1912, 1916, 1920, 1924,
                                            1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980,
                                            1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036,
                                            2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092,
                                            2096, 2104, 2108, 2112, 2116, 2120, 2124, 2128, 2132, 2136, 2140, 2144, 2148, 2152,
                                            2156, 2160, 2164, 2168, 2172, 2176, 2180, 2184, 2188, 2192, 2196, 2204, 2208, 2212,
                                            2216, 2220, 2224, 2228, 2232, 2236, 2240, 2244, 2248, 2252, 2256, 2260, 2264, 2268,
                                            2272, 2276, 2280, 2284, 2288, 2292, 2296, 2304, 2308, 2312, 2316, 2320, 2324, 2328,
                                            2332, 2336, 2340, 2344, 2348, 2352, 2356, 2360, 2364, 2368, 2372, 2376, 2380, 2384,
                                            2388, 2392, 2396, 2400, 2404, 2408, 2412, 2416, 2420, 2424, 2428, 2432, 2436, 2440,
                                            2444, 2448, 2452, 2456, 2460, 2464, 2468, 2472, 2476, 2480, 2484, 2488, 2492, 2496,
                                            2504, 2508, 2512, 2516, 2520, 2524, 2528, 2532, 2536, 2540, 2544, 2548, 2552, 2556,
                                            2560, 2564, 2568, 2572, 2576, 2580, 2584, 2588, 2592, 2596, 2604, 2608, 2612, 2616,
                                            2620, 2624, 2628, 2632, 2636, 2640, 2644, 2648, 2652, 2656, 2660, 2664, 2668, 2672,
                                            2676, 2680, 2684, 2688, 2692, 2696, 2704, 2708, 2712, 2716, 2720, 2724, 2728, 2732,
                                            2736, 2740, 2744, 2748, 2752, 2756, 2760, 2764, 2768, 2772, 2776, 2780, 2784, 2788,
                                            2792, 2796, 2800, 2804, 2808, 2812, 2816, 2820, 2824, 2828, 2832, 2836, 2840, 2844,
                                            2848, 2852, 2856, 2860, 2864, 2868, 2872, 2876, 2880, 2884, 2888, 2892, 2896, 2904,
                                            2908, 2912, 2916, 2920, 2924, 2928, 2932, 2936, 2940, 2944, 2948, 2952, 2956, 2960,
                                            2964, 2968, 2972, 2976, 2980, 2984, 2988, 2992, 2996 };

            foreach (ushort y in leapYears)
            {
                Year year = new Year(y);
                ushort monthCount = 0;

                foreach (Month month in year._months)
                {
                    monthCount++;
                    switch ((Month.eMONTHS)month._value)
                    {
                        case Month.eMONTHS.JANUARY:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.FEBRUARY:
                            if (29 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.MARCH:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.APRIL:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.MAY:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.JUNE:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.JULY:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.AUGUST:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.SEPTEMBER:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.OCTOBER:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.NOVEMBER:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.DECEMBER:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test0 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;

                        default:
                            result = false;
                            break;
                    }//switch ((Month.eMONTHS)month._value)

                    /* Break early if in a failure case */
                    if (!result)
                    {
                        break;
                    }
                }

                if (12 != monthCount)
                {
                    result = false;
                }

                /* Break early if in a failure case */
                if (!result)
                {
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("     YearCon_Test0 - PASS");
            }

            return result;
        }
        private bool YearCon_Test1()
        {
            bool result = false;

            /* Leap years from 1582 to 3000, taken from https://miniwebtool.com/leap-years-list/?start_year=1582&end_year=3000 */
            ushort[] leapYears = new ushort[] {   1584, 1588, 1592, 1596, 1600, 1604, 1608, 1612, 1616, 1620, 1624, 1628, 1632,
                                            1636, 1640, 1644, 1648, 1652, 1656, 1660, 1664, 1668, 1672, 1676, 1680, 1684, 1688,
                                            1692, 1696, 1704, 1708, 1712, 1716, 1720, 1724, 1728, 1732, 1736, 1740, 1744, 1748,
                                            1752, 1756, 1760, 1764, 1768, 1772, 1776, 1780, 1784, 1788, 1792, 1796, 1804, 1808,
                                            1812, 1816, 1820, 1824, 1828, 1832, 1836, 1840, 1844, 1848, 1852, 1856, 1860, 1864,
                                            1868, 1872, 1876, 1880, 1884, 1888, 1892, 1896, 1904, 1908, 1912, 1916, 1920, 1924,
                                            1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980,
                                            1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036,
                                            2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092,
                                            2096, 2104, 2108, 2112, 2116, 2120, 2124, 2128, 2132, 2136, 2140, 2144, 2148, 2152,
                                            2156, 2160, 2164, 2168, 2172, 2176, 2180, 2184, 2188, 2192, 2196, 2204, 2208, 2212,
                                            2216, 2220, 2224, 2228, 2232, 2236, 2240, 2244, 2248, 2252, 2256, 2260, 2264, 2268,
                                            2272, 2276, 2280, 2284, 2288, 2292, 2296, 2304, 2308, 2312, 2316, 2320, 2324, 2328,
                                            2332, 2336, 2340, 2344, 2348, 2352, 2356, 2360, 2364, 2368, 2372, 2376, 2380, 2384,
                                            2388, 2392, 2396, 2400, 2404, 2408, 2412, 2416, 2420, 2424, 2428, 2432, 2436, 2440,
                                            2444, 2448, 2452, 2456, 2460, 2464, 2468, 2472, 2476, 2480, 2484, 2488, 2492, 2496,
                                            2504, 2508, 2512, 2516, 2520, 2524, 2528, 2532, 2536, 2540, 2544, 2548, 2552, 2556,
                                            2560, 2564, 2568, 2572, 2576, 2580, 2584, 2588, 2592, 2596, 2604, 2608, 2612, 2616,
                                            2620, 2624, 2628, 2632, 2636, 2640, 2644, 2648, 2652, 2656, 2660, 2664, 2668, 2672,
                                            2676, 2680, 2684, 2688, 2692, 2696, 2704, 2708, 2712, 2716, 2720, 2724, 2728, 2732,
                                            2736, 2740, 2744, 2748, 2752, 2756, 2760, 2764, 2768, 2772, 2776, 2780, 2784, 2788,
                                            2792, 2796, 2800, 2804, 2808, 2812, 2816, 2820, 2824, 2828, 2832, 2836, 2840, 2844,
                                            2848, 2852, 2856, 2860, 2864, 2868, 2872, 2876, 2880, 2884, 2888, 2892, 2896, 2904,
                                            2908, 2912, 2916, 2920, 2924, 2928, 2932, 2936, 2940, 2944, 2948, 2952, 2956, 2960,
                                            2964, 2968, 2972, 2976, 2980, 2984, 2988, 2992, 2996 };

            foreach (ushort y in leapYears)
            {
                Year year = new Year((ushort)(y + 1u));
                ushort monthCount = 0;

                foreach (Month month in year._months)
                {
                    monthCount++;
                    switch ((Month.eMONTHS)month._value)
                    {
                        case Month.eMONTHS.JANUARY:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.FEBRUARY:
                            if (28 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.MARCH:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.APRIL:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.MAY:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.JUNE:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.JULY:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.AUGUST:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.SEPTEMBER:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.OCTOBER:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.NOVEMBER:
                            if (30 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;
                        case Month.eMONTHS.DECEMBER:
                            if (31 == month._days.Length)
                            {
                                result = true;
                            }
                            else
                            {
                                Console.WriteLine("     YearCon_Test1 - FAIL at " + month._name + year._value.ToString());
                                /* Fail early */
                                result = false;
                            }
                            break;

                        default:
                            result = false;
                            break;
                    }//switch ((Month.eMONTHS)month._value)

                    /* Break early if in a failure case */
                    if (!result)
                    {
                        break;
                    }
                }

                if (12 != monthCount)
                {
                    result = false;
                }

                /* Break early if in a failure case */
                if (!result)
                {
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("     YearCon_Test1 - PASS");
            }

            return result;
        }
        #endregion
        #region WEEKDAY CALC
        private bool DetermineWeekDay_Test0_MONDAY()
        {
            bool result = false;

            ushort day = 1;
            ushort month = 4;
            ushort year = 2019;

            if (Day.eWEEKDAY.MONDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test0_MONDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test0_MONDAY - FAIL");
            }

            return result;
        }
        private bool DetermineWeekDay_Test1_TUESDAY()
        {
            bool result = false;

            ushort day = 5;
            ushort month = 5;
            ushort year = 2026;

            if (Day.eWEEKDAY.TUESDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test1_TUESDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test1_TUESDAY - FAIL");
            }

            return result;
        }
        private bool DetermineWeekDay_Test2_WEDNESDAY()
        {
            bool result = false;

            ushort day = 3;
            ushort month = 6;
            ushort year = 1874;

            if (Day.eWEEKDAY.WEDNESDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test2_WEDNESDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test2_WEDNESDAY - FAIL");
            }

            return result;
        }
        private bool DetermineWeekDay_Test3_THURSDAY()
        {
            bool result = false;

            ushort day = 27;
            ushort month = 11;
            ushort year = 2008;

            if (Day.eWEEKDAY.THURSDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test3_THURSDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test3_THURSDAY - FAIL");
            }

            return result;
        }
        private bool DetermineWeekDay_Test4_FRIDAY()
        {
            bool result = false;

            ushort day = 7;
            ushort month = 2;
            ushort year = 1986;

            if (Day.eWEEKDAY.FRIDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test4_FRIDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test4_FRIDAY - FAIL");
            }

            return result;
        }
        private bool DetermineWeekDay_Test5_SATURDAY()
        {
            bool result = false;

            ushort day = 18;
            ushort month = 4;
            ushort year = 1970;

            if (Day.eWEEKDAY.SATURDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test5_SATURDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test5_SATURDAY - FAIL");
            }

            return result;
        }
        private bool DetermineWeekDay_Test6_SUNDAY()
        {
            bool result = false;

            ushort day = 5;
            ushort month = 1;
            ushort year = 3000;

            if (Day.eWEEKDAY.SUNDAY == Day.DetermineWeekDay(day, month, year))
            {
                Console.WriteLine("     DetermineWeekDay_Test6_SUNDAY - PASS");
                result = true;
            }
            else
            {
                Console.WriteLine("     DetermineWeekDay_Test6_SUNDAY - FAIL");
            }

            return result;
        }
        #endregion
        #endregion
    }
}
#endif
