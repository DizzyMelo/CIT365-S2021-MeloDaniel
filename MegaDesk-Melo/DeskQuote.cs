using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Melo
{
    class DeskQuote
    {
        private string name;
        private DateTime date;
        private Desk desk;

        public DeskQuote() { }
        
        public DeskQuote(Desk desk, string name)
        {
            this.name = name;
            this.desk = desk;
            date = DateTime.Now;
        }

        public string Name { get; set; }

        public int calculateTotalPrice() 
        {
            int total = 200;

            total += (50 * desk.NumDrawers);
            total += calculateDifference();
            total += selectDesktopMaterialCost();
            total += selectRushOrderCost();
            

            return total;
        }

        private int calculateDifference()
        {
            int size = desk.Depth * desk.Width;
            if (size <= 1000)
                return 0;
            else
                return size - 1000;
        }

        private int selectRushOrderCost()
        {
            int cost = 0;
            int size = desk.Width * desk.Depth;

            switch (desk.RushOption)
            {
                case 3:
                    if (size < 1000)
                        cost = 60;
                    else if (size >= 1000 && size < 2000)
                        cost = 70;
                    else
                        cost = 80;
                    break;
                case 5:
                    if (size < 1000)
                        cost = 40;
                    else if (size >= 1000 && size < 2000)
                        cost = 50;
                    else
                        cost = 60;
                    break;
                case 7:
                    if (size < 1000)
                        cost = 30;
                    else if (size >= 1000 && size < 2000)
                        cost = 35;
                    else
                        cost = 40;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private int selectDesktopMaterialCost()
        {
            int cost = 0;
            switch (desk.SurfaceMaterial)
            {
                case DesktopMaterial.Oak:
                    cost = 200;
                    break;

                case DesktopMaterial.Laminate:
                    cost = 100;
                    break;

                case DesktopMaterial.Pine:
                    cost = 50;
                    break;

                case DesktopMaterial.Rosewood:
                    cost = 300;
                    break;

                case DesktopMaterial.Venner:
                    cost = 125;
                    break;
            }
            return cost;
        }
    }
}
