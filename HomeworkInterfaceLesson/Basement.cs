using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Basement : IPart
    {        
        public void ConstructionSite(House house)
        {
            house.Basement = new Basement();
        }
    }
}
