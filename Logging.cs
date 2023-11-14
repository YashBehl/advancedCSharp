using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    class Logging
    {
        public enum LogTypes
        {
            Error,
            Warnings,
            Fatal,
            Information
        }

        public void WriteLog(string logMessage, LogTypes logTypes)
        {
            switch(logTypes)
            {
                case LogTypes.Fatal:
                    Console.WriteLine("Write fatal log");
                    break;

                case LogTypes.Error:
                    Console.WriteLine("Write error log");
                    break;

                case LogTypes.Warnings:
                    Console.WriteLine("Write warning log");
                    break;

                case LogTypes.Information:
                    Console.WriteLine("Write information log");
                    break;
            }
        }
    }
}
