using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Melo
{
    class ShowQuote
    {
        public string Name { get; set; }
        public int Depth { get; set; }
        public int Width { get; set; }
        public int Price { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }
        public int RushOption { get; set; }
        public DateTime Date { get; set; }
    }
}
