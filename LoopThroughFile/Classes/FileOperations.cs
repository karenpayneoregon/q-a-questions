using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopThroughFile.Classes
{
    public class FileOperations
    {
        public delegate void ProcessLine(string[] sender);

        public event ProcessLine ProcessLineEvent;
        public void ReadFile(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                ProcessLineEvent?.Invoke(line.Split(','));
            }
        }
    }
}
