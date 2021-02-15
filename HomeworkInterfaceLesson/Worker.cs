using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Worker : IWorker
    {        
        public string Name { get; set ; }       
        public Worker(string name)
        {
            Name = name;
        }
        public void Сonstruction(House house, TeamLeader teamLeader)
        {
            if (house.Basement == null)
            {
                Basement basement = new Basement();
                basement.ConstructionSite(house);
                teamLeader.report.Add($"Строитель {Name} залил фундамент!");
            }
            else if (house.Walls == null || house.Walls.Count < 4)
            {
                if (house.Walls == null)
                {
                    house.Walls = new List<Walls>();
                }
                Walls wall = new Walls();
                wall.ConstructionSite(house);
                teamLeader.report.Add($"Строитель {Name} построил {house.Walls.Count} стену !");
            }
            else if (house.Door == null)
            {
                Door door = new Door();
                door.ConstructionSite(house);
                teamLeader.report.Add($"Строитель {Name} смонтировал дверь!");

            }

            else if (house.Windows == null || house.Windows.Count < 4)
            {
                if (house.Windows == null) house.Windows = new List<Window>();
                Window window = new Window();
                window.ConstructionSite(house);
                teamLeader.report.Add($"Строитель {Name} поставил {house.Windows.Count} окно!");

            }

            else if (house.Roof == null)
            {
                Roof roof = new Roof();
                roof.ConstructionSite(house);
                teamLeader.report.Add($"Строитель {Name} накрыл крышу!");

            }

        }
    }
}
