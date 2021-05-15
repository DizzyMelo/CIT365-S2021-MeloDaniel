using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace MegaDesk_Melo
{
    class DeskQuote
    {
        public DeskQuote() { }
        

        public string Name { get; set; }
        public Desk Desk { get; set; }
        public DateTime Date { get; set; }
        public int RushOption { get; set; }

        public static bool SavaQuote(DeskQuote quote)
        {
            string filepath = "quotes.json";
            try
            {
                string json = System.IO.File.ReadAllText(filepath);
                    List<DeskQuote> items = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                    items.Add(quote);

                json = JsonConvert.SerializeObject(items);
                System.IO.File.WriteAllText(filepath, json);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public int [,] GetRushOrder()
        {
            string file = "rushOrderPrices.txt";

            int[,] additionalCharges = new int[3, 3];

            try
            {
                string[] lines = File.ReadAllLines(file);

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        additionalCharges[i, j] = int.Parse(lines[j + (3 * i)]);
                    }
                }
            }
            catch (IOException)
            {
                throw new IOException();
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }

            return additionalCharges;
        }

        public List<ShowQuote> ReadQuotes()
        {
            using (StreamReader r = new StreamReader("quotes.json"))
            {
                string json = r.ReadToEnd();
                List<DeskQuote> items = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

                List<ShowQuote> quotes = new List<ShowQuote>();
                foreach(DeskQuote item in items)
                {
                    ShowQuote quote = new ShowQuote();
                    quote.Name = item.Name;
                    quote.Depth = item.Desk.Depth;
                    quote.Width = item.Desk.Width;
                    quote.NumDrawers = item.Desk.NumDrawers;
                    quote.DesktopMaterial = item.Desk.SurfaceMaterial;
                    quote.RushOption = item.RushOption;
                    quote.Date = item.Date;
                    quote.Price = item.calculateTotalPrice();

                    quotes.Add(quote);
                }

                return quotes;
            }
        }

        public List<ShowQuote> FilterQuotes(DesktopMaterial material)
        {
            using (StreamReader r = new StreamReader("quotes.json"))
            {
                string json = r.ReadToEnd();
                List<DeskQuote> items = JsonConvert
                    .DeserializeObject<List<DeskQuote>>(json)
                    .FindAll((DeskQuote quote) => { return quote.Desk.SurfaceMaterial == material; });
                
                List<ShowQuote> quotes = new List<ShowQuote>();
                foreach (DeskQuote item in items)
                {
                    ShowQuote quote = new ShowQuote();
                    quote.Name = item.Name;
                    quote.Depth = item.Desk.Depth;
                    quote.Width = item.Desk.Depth;
                    quote.Price = item.calculateTotalPrice();
                    quote.NumDrawers = item.Desk.NumDrawers;
                    quote.DesktopMaterial = item.Desk.SurfaceMaterial;
                    quote.RushOption = item.RushOption;
                    quote.Date = item.Date;

                    quotes.Add(quote);
                }

                return quotes;
            }
        }

        public int calculateTotalPrice() 
        {
            int total = 200;

            total += (50 * this.Desk.NumDrawers);
            total += calculateDifference();
            total += selectDesktopMaterialCost();
            total += selectRushOrderCost();
            

            return total;
        }

        private int calculateDifference()
        {
            int size = this.Desk.Depth * this.Desk.Width;
            if (size <= 1000)
                return 0;
            else
                return size - 1000;
        }

        private int selectRushOrderCost()
        {
            int cost = 0;
            int size = this.Desk.Width * this.Desk.Depth;

            int [,] additionalCharges = GetRushOrder();

            switch (this.RushOption)
            {
                case 3:
                    if (size < 1000)
                        cost = additionalCharges[0,0];
                    else if (size >= 1000 && size < 2000)
                        cost = additionalCharges[1, 0];
                    else
                        cost = additionalCharges[2, 0];
                    break;
                case 5:
                    if (size < 1000)
                        cost = additionalCharges[0, 1];
                    else if (size >= 1000 && size < 2000)
                        cost = additionalCharges[1, 1];
                    else
                        cost = additionalCharges[2, 1];
                    break;
                case 7:
                    if (size < 1000)
                        cost = additionalCharges[0, 2];
                    else if (size >= 1000 && size < 2000)
                        cost = additionalCharges[1, 2];
                    else
                        cost = additionalCharges[2, 2];
                    break;
                default:
                    break;
            }

            return cost;
        }

        private int selectDesktopMaterialCost()
        {
            int cost = 0;
            switch (this.Desk.SurfaceMaterial)
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
