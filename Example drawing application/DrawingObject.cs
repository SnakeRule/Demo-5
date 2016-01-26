using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_drawing_application
{

    abstract class DrawingObject
    {

        public string Name { get; set; }
        public abstract void Draw();
    }
}
