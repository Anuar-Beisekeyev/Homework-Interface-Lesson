using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class TeamLeader : IWorker
    {
        public string Name { get ; set ; }
        public List<string> report = new List<string>();        
        public TeamLeader(string name)
        {
            Name = name;
        }
        public void Report()
        {
            double percentageOfCompletedWork = (report.Count / 11.0) * 100;
            Console.WriteLine($"Процент завершенных работ - {(int)percentageOfCompletedWork} %");
        }
    }
}
