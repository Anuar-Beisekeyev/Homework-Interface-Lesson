using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Roof : IPart
    {
        public void ConstructionSite(House house)
        {
            house.Roof = new Roof();
        }
    }
}
