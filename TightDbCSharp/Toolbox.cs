﻿using System;

namespace TightDbCSharp
{
    /// <summary>
    /// This class contains diagnostics, test and benchmark functionality.
    /// 
    /// </summary>
    public static class Toolbox //only static methods for now, but may become non static later on
    {

        /// <summary>
        /// This method will call the Cpp dll and the dll will then
        /// create a table, and call table.size() 1 million times
        /// then the cpp dll will return
        /// timing this call can be compared to doing the same in
        /// C#, and thus, get a benchmark reg. the overhead with
        /// calling from C# to cpp
        /// The method is used in performancetest.cs in examples
        /// </summary>
        public static long TestNativeSizeCalls()
        {
            return UnsafeNativeMethods.TestSizeCalls();
        }


        /// <summary>
        /// Will display C# assembly, 
        /// c++ dll, runtime environment, bit size and operating system
        /// information on the console.
        /// </summary>
        public static void ShowVersionTest()
        {
            Console.WriteLine(GetCSharpInfo());
            Console.WriteLine(GetCInfo());
        }

        /// <summary>
        /// Return string with list of lines with
        /// system information, suitable for
        /// console output
        /// </summary>
        /// <returns>Info reg. the OS, runtime environment, assembly etc.</returns>
        public static string GetCSharpInfo()
        {
            return UnsafeNativeMethods.GetCsInfo();
        }

        /// <summary>
        /// Only used by unit tests
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Int64 DebugToTightDbTime(DateTime date)
        {
            return UnsafeNativeMethods.ToTightDbDateTime(date);
        }


        /// <summary>
        /// Only used by unit tests
        /// </summary>
        /// <param name="linuxTime"></param>
        /// <returns></returns>
        public static DateTime DebugToCSharpTimeUtc(Int64 linuxTime)
        {
            return UnsafeNativeMethods.ToCSharpTimeUtc(linuxTime);
        }

        /// <summary>
        /// Tests basic interop, used when building experimentally on new platforms
        /// </summary>
        public static void TestInterop()
        {
            UnsafeNativeMethods.TestInterop();

        }


        /// <summary>
        /// Return string with list of lines with
        /// system information, suitable for
        /// console output
        /// </summary>
        /// <returns>Info reg. the C DLL - location, name etc</returns>
        public static string GetCInfo()
        {
            return UnsafeNativeMethods.GetCppInfo();
        }
    }
}
