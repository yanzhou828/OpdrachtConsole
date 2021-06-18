﻿
namespace OpdrachtConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\OpdrachtConsole\temperature.dat";
            int tagWidth=4;
            int columnAStart=4; 
            int columnAWidth=5;
            int columnBStart=9; 
            int columnBWidth=6; 
            string message= "The smallest temperature spread day: ";
            SmallestDifference.SmallestDiff(fileName, tagWidth, columnAStart, columnAWidth, columnBStart, columnBWidth, message);

            fileName = @"D:\OpdrachtConsole\socker.dat";
            tagWidth = 23;
            columnAStart = 40;
            columnAWidth = 6;
            columnBStart = 49;
            columnBWidth = 5;
            message = "The smallest difference socker team: ";
            SmallestDifference.SmallestDiff(fileName, tagWidth, columnAStart, columnAWidth, columnBStart, columnBWidth, message);
        }
    }

}
