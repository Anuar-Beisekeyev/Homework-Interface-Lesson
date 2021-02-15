using System;

namespace HomeworkInterfaceLesson
{    
    class Program
    {       
        static void Main(string[] args)        
        {
            House house = new House();
            Team team = new Team();

            Console.WriteLine( $"Строительная компания \"{team.Name}\".\n");
            Random random = new Random();
            bool flag = true; 
            while (flag)
            {
                Console.WriteLine( $"Бригадир {team.TeamLeader.Name} проводит проверку!"); 
                for (int i = 0; i < random.Next(0, 6); i++)
                {
                    team.Workers[random.Next(0, 3)].Сonstruction(house, team.TeamLeader);
                }
                foreach (var item in team.TeamLeader.report)
                {
                    Console.WriteLine(item);
                }
                team.TeamLeader.Report();
                Console.WriteLine();
                if (team.TeamLeader.report.Count == 11)
                {
                    flag = false;
                }
            }
            house.DrawHouse(team.TeamLeader);
           
            Console.ReadLine();
        }    
    }
}
