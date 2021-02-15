using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Walls : IPart
    {
        public void ConstructionSite(House house)
        {
            house.Walls.Add(new Walls());
        }
    }
}
