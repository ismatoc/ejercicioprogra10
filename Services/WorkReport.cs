using SingleResponsibility.Classes;
using SingleResponsibility.Interfaces;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Services
{
    public class WorkReport : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entries;
        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }
        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);
        public void RemoveEntry(int index) => _entries.RemoveAt(index);
       
        //Override
        //Overload
        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name:{x.ProjectName}, Hours: {x.SpectHours}"));
        
    }
}
