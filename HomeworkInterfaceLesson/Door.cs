using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Door : IPart
    {     
        public void ConstructionSite(House house)
        {
            house.Door = new Door();
        }
    }
}
