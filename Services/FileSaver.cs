using SingleResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Services
{
    public class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
