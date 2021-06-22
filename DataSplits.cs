using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtConsole
{
    public static class DataSplits
    {
        public static void Solution2(string fileName)
        {

            List<DataDiff> lstTemp = new List<DataDiff>();
            int smallestNumber = 0;
            int number;
            bool isParsable;
            bool firstValue = true;
            foreach (string line in File.ReadLines(fileName))
            {
                string[] ds = line.Split(" ");
                int len = ds.Length;
                //    if (line != string.Empty)
                //    {
                //        isParsable = Int32.TryParse(line.Substring(0, 5), out number);

                //        if (isParsable)
                //        {
                //            DataDiff df = new DataDiff();
                //            df.Tag = line.Substring(0, tagWidth).Trim();

                //            if (line.Substring(columnAStart, 5).Trim().Contains('*'))
                //            {
                //                df.ColumnA = Int32.Parse(line.Substring(columnAStart, columnAWidth - 1).Trim());
                //            }
                //            else
                //            {
                //                df.ColumnA = Int32.Parse(line.Substring(columnAStart, columnAWidth).Trim());
                //            }
                //            if (line.Substring(9, 6).Trim().Contains('*'))
                //            {
                //                df.ColumnB = Int32.Parse(line.Substring(columnBStart, columnBWidth - 1).Trim());
                //            }
                //            else
                //            {
                //                df.ColumnB = Int32.Parse(line.Substring(columnBStart, columnBWidth).Trim());
                //            }
                //            //string showLine = df.Tag + " " + df.ColumnA.ToString() + " " + df.ColumnB.ToString();
                //            //Console.WriteLine(showLine);
                //            if (firstValue)
                //            {
                //                smallestNumber = Math.Abs(df.ColumnA - df.ColumnB);
                //                firstValue = false;
                //            }
                //            if (smallestNumber > Math.Abs(df.ColumnA - df.ColumnB))
                //            {
                //                smallestNumber = Math.Abs(df.ColumnA - df.ColumnB);
                //            }
                //            lstTemp.Add(df);
                //        }
                //    }
                //foreach (var item in ds)
                //{
                //    System.Console.WriteLine($"<{ds}>");
                //    //if (Math.Abs(item.ColumnA - item.ColumnB) == smallestNumber)
                //    //{
                //    //    Console.WriteLine(item.Tag + "\n");
                //    //}
                //}
            
             };

            //Console.WriteLine(message);
            //foreach (var item in ds)
            //{
            //    //if (Math.Abs(item.ColumnA - item.ColumnB) == smallestNumber)
            //    //{
            //    //    Console.WriteLine(item.Tag + "\n");
            //    //}
            //}
        }
    }
 }
