using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Team : IWorker
    {        
        public TeamLeader TeamLeader { get; set; }
        public List<Worker> Workers { get; set; }
        public string Name { get; set; } = "Стройкачество";
        public Team()
        {
            TeamLeader = new TeamLeader("Федор Михайлович");
            Workers = new List<Worker>
            {
                new Worker("Арман"),
                new Worker("Иван"),
                new Worker("Байкелди"),
                new Worker("Замир")
            };
        }
    }
}
