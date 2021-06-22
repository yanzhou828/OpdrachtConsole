using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OpdrachtConsole
{
    public static class SmallestDifference
    {
        public static void SmallestDiff(string fileName, int tagWidth, int columnAStart, int columnAWidth, int columnBStart, int columnBWidth, string message)
        {

            List<DataDiff> lstTemp = new List<DataDiff>();
            int smallestNumber = 0;
            int number;
            bool isParsable;
            bool firstValue = true;
            foreach (string line in File.ReadLines(fileName))
            {
                if (line != string.Empty)
                {
                    isParsable = Int32.TryParse(line.Substring(0, 5), out number);

                    if (isParsable)
                    {
                        DataDiff df = new DataDiff();
                        df.Tag = line.Substring(0, tagWidth).Trim();

                        if (line.Substring(columnAStart, 5).Trim().Contains('*'))
                        {
                            df.ColumnA = Int32.Parse(line.Substring(columnAStart, columnAWidth-1).Trim());
                        }
                        else
                        {
                            df.ColumnA = Int32.Parse(line.Substring(columnAStart, columnAWidth).Trim());
                        }
                        if (line.Substring(9, 6).Trim().Contains('*'))
                        {
                            df.ColumnB = Int32.Parse(line.Substring(columnBStart, columnBWidth-1).Trim());
                        }
                        else
                        {
                            df.ColumnB = Int32.Parse(line.Substring(columnBStart, columnBWidth).Trim());
                        }
                        //string showLine = df.Tag + " " + df.ColumnA.ToString() + " " + df.ColumnB.ToString();
                        //Console.WriteLine(showLine);
                        if (firstValue)
                        {
                            smallestNumber = Math.Abs(df.ColumnA - df.ColumnB);
                            firstValue = false;
                        }
                        if (smallestNumber > Math.Abs(df.ColumnA - df.ColumnB))
                        {
                            smallestNumber = Math.Abs(df.ColumnA - df.ColumnB);
                        }
                        lstTemp.Add(df);
                    }
                }
            };

            Console.WriteLine(message);
            foreach (var item in lstTemp)
            {
                if (Math.Abs(item.ColumnA - item.ColumnB) == smallestNumber)
                {
                    Console.WriteLine(item.Tag + "\n");
                }
            }

        }

        public static void Oplossing2(string fileName, string colA, string colB, string message)
        {
            decimal smallestNumber = 0;
            int col1=0;
            int col2=0;
            bool firstValue = true;
            bool colName = false;
            List<DataTemp> lstTemp = new List<DataTemp>();
            foreach (string line in File.ReadLines(fileName))
            {
                if (line != string.Empty)
                {
                    var x = StringSplit(line);
                    if (x != null && x.Length > 3)     // remove streep
                    {
                        if (!colName)
                        {   // Search column name
                            for (int i = 0; i <= x.Length - 1; i++)
                            {
                                if (x[i] == colA)
                                    col1 = i;
                                if (x[i] == colB)
                                    col2 = i;
                                colName = true;
                            }
                        }
                        else
                        {
                            DataTemp df = new DataTemp();
                            df.Tag = x[0].Trim();

                            df.ColumnA = x[col1].Trim().Contains('*') ? decimal.Parse(x[col1].Substring(0, x[col1].Length - 1).Trim()) : decimal.Parse(x[col1].Trim());
                            df.ColumnB = x[col2].Trim().Contains('*') ? decimal.Parse(x[col2].Substring(0, x[col2].Length - 1).Trim()) : decimal.Parse(x[col2].Trim());

                            decimal curTemp = Math.Abs(df.ColumnA - df.ColumnB);
                            if (firstValue)
                            {
                                smallestNumber = curTemp;
                                firstValue = false;
                            }

                            if (smallestNumber > curTemp)
                            {
                                smallestNumber = curTemp;
                            }
                            lstTemp.Add(df);
                        }
                    }
                }
            }
            Console.WriteLine(message);
            foreach (var item in lstTemp)
            {
                if (Math.Abs(item.ColumnA - item.ColumnB) == smallestNumber)
                {
                    Console.WriteLine(item.Tag + "\n");
                }
            }

        }

        private static string[] StringSplit(string inputString)
        {
            string[] stringAfterSplit = inputString.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            //Remove unnecessary columns
            List<string> lstArray = stringAfterSplit.ToList<string>();            
            lstArray.RemoveAll(p => string.Equals(p, "-"));
            lstArray.RemoveAll(p => p.EndsWith("."));
            // remove last total record
            if (lstArray[0] == "mo")
                return null;

            return lstArray.ToArray();
        }
    }
}
