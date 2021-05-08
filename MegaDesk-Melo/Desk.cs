using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Melo
{
    class Desk
    {
        private int width;
        private int depth;
        private int numDrawers;
        private DesktopMaterial surfaceMaterial;
        private int rushOption;

        public const int MAXIMUM_WIDTH = 96;
        public const int MINIMUM_WIDTH = 24;
        public const int MAXIMUM_DEPTH = 48;
        public const int MINIMUM_DEPTH = 12;



        public int Depth { get; set; }
        public int Width { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
        public int RushOption { get; set; }

    }
    public enum DesktopMaterial { Oak, Laminate, Pine, Rosewood, Venner }
}
