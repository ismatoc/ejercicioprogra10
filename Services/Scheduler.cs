using SingleResponsibility.Classes;
using SingleResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Services
{
    public class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _scheduleTasks;
        public Scheduler()
        {
            _scheduleTasks = new List<ScheduleTask>();
        }

        public void AddEntry(ScheduleTask entry) => _scheduleTasks.Add(entry);

        public void RemoveEntry(int index) => _scheduleTasks.RemoveAt(index);
        public override string ToString() =>
            string.Join(Environment.NewLine, _scheduleTasks.Select(x => $"Task with id:{x.TaskId }, Content: {x.Content}, ExecuteON: {x.ExecuteON}"));
    }
}
