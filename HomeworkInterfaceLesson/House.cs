using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class House 
    {
        public Basement Basement { get; set; }
        public List<Walls> Walls { get; set; }
        public List<Window> Windows { get; set; }
        public Door Door { get; set; }
        public Roof Roof { get; set; }

        public void DrawHouse(TeamLeader teamLeader)
        {
            if (teamLeader.report.Count == 11)
            {

                string home = @"
                     
                                 ( )
                               (     )
                                 (  )
                                )  )
                                 (__)                                     /\    
                                 [  ]                                    /  \  /\
                             ____[__]___________________________      /\/    \/  \
                            /                /\                 \    /   /\/\  /\ \
                           /                /  \                 \  /\/\/    \/  \
                          /                /____\                 \/               (())
                         /                 |    |                  \             (())(())
                        /__________________|_[]_|___________________\            (((\/)))
                        |  ______  ______          ______  ______   |             (\  /)
                        |  | || |  | || |  ______  | || |  | || |   |---   -------  [] 
                        |  | || |  | || |  | || |  | || |  | || |   | --------------[]  --------
                        |  |_||_|  |_||_|  | || |  |_||_|  |_||_|   |    ----     ---------
                        |                  | || |                   | 
                        |__________________|_||_|___________________| 
                        |___________________________________________| 
                     ******************************************************************************";

                Console.WriteLine(home);
            }
            else
            {
                Console.WriteLine("Дом не достроен!");
            }
        }
           
        }

}
