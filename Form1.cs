using SingleResponsibility.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            MakeReport();
        }
        private void MakeReport() {
            var report = new WorkReport();
            report.AddEntry(new Classes.WorkReportEntry { ProjectCode = codigo.Text, ProjectName = nombre_projecto.Text, SpectHours = Int32.Parse(hora.Text) });
            /*report.AddEntry(new Classes.WorkReportEntry { ProjectCode = "175EEE", ProjectName = "Name Test 2", SpectHours = 25 });
            report.AddEntry(new Classes.WorkReportEntry { ProjectCode = "858EWW", ProjectName = "Name Test 3", SpectHours = 35 });*/

            var scheduler = new Scheduler();
            scheduler.AddEntry(new Classes.ScheduleTask { TaskId = 1, Content = "Something todo", ExecuteON = DateTime.Now });
            scheduler.AddEntry(new Classes.ScheduleTask { TaskId = 2, Content = "Something todo againg", ExecuteON = DateTime.Now.AddDays(2) });
            
            Console.WriteLine(report.ToString());
            Console.WriteLine(scheduler.ToString());
            //TODO --> Separarlo add de save

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
        }

        private void MakeScheduler()
        {
            var scheduler = new Scheduler();
            scheduler.AddEntry(new Classes.ScheduleTask { TaskId = 1, Content = Tarea.Text, ExecuteON = DateTime.Now });
            /*scheduler.AddEntry(new Classes.ScheduleTask { TaskId = 2, Content = "Something todo againg", ExecuteON = DateTime.Now.AddDays(2) });*/

            
            Console.WriteLine(scheduler.ToString());
            //TODO --> Separarlo add de save

            var saver = new FileSaver();
           
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeScheduler();
        }
    }
}
