using System;
using System.Collections.Generic;
using System.IO;

namespace LoopThroughFile.Classes
{
    public class Operations
    {
        public static (decimal total, List<int> linesBad, Exception exception) GetTotals(string fileName)
        {
            List<int> badLines = new();
            decimal total = 0;

            try
            {
                using (StreamReader reader = new(fileName))
                {
                    int index = 0;
                    while (!reader.EndOfStream)
                    {
                        if (decimal.TryParse(reader.ReadLine(), out var result))
                        {
                            total += result;
                        }
                        else
                        {
                            badLines.Add(index);
                        }

                        index++;
                    }
                }

                return (total, badLines, null);

            }
            catch (Exception ex)
            {
                return (total, badLines, ex);
            }
        }
    }
}
