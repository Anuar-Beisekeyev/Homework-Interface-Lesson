using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInterfaceLesson
{
    public class Window : IPart
    {        
        public void ConstructionSite(House house)
        {
            house.Windows.Add(new Window());
        }
    }
}
