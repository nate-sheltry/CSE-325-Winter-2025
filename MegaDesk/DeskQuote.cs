using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using MegaDesk;
using System.IO;

namespace MegaDesk
{
    internal class DeskQuote
    {
        private static string file = "Desks.txt";

        public int width;
        public int depth;
        public int drawers;

        public int order;
        public DesktopMaterial material;
        public string customerName;

        public DateTime date;
        public float price;

        public override string ToString()
        {
            return (
                $"Width: {this.width}, Depth: {this.depth}, "+
                $"Drawers: {this.drawers}\n"+
                $"Order: {this.order}, Material: {this.material}\n"+
                $"Name: {this.customerName}, Price: {this.price}"
                );
        }

        private string serialize()
        {
            string str = "";

            str += "{\n";
            str += $"customerName:\"{this.customerName}\"\n";
            str += $"width:{this.width}\n";
            str += $"depth:{this.depth}\n";
            str += $"drawers:{this.drawers}\n";
            str += $"order:{this.order}\n";
            str += $"material:\"{this.material}\"\n";
            str += $"date:\"{this.date.ToString()}\"\n";
            str += "}\n";

            return str;
        }

        public DeskQuote
        (
            int width, int depth, int drawers,
            int order, DesktopMaterial material,
            string customerName, DateTime? date = null
        )
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;

            this.order = order;
            this.material = material;
            this.customerName = customerName;
            this.date = date ?? DateTime.Now;
            this.price = calculatePrice(width, depth, drawers, material, order);
        }

        private float calculatePrice(
            int width, int depth, int drawers,
            DesktopMaterial material,int order
            )
        {
            float price = 200;
            price += 50 * drawers;

            int surfaceArea = width * depth;

            if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                price += surfaceArea - 1000;
                switch (order)
                {
                    case 3:
                        price += 70; break;
                    case 5:
                        price += 50; break;
                    case 7:
                        price += 35; break;
                }
            }
            else if (surfaceArea > 2000)
            {
                price += surfaceArea - 1000;
                switch (order)
                {
                    case 3:
                        price += 80; break;
                    case 5:
                        price += 60; break;
                    case 7:
                        price += 40; break;
                }
            }
            else
            {
                switch (order)
                {
                    case 3:
                        price += 60; break;
                    case 5:
                        price += 40; break;
                    case 7:
                        price += 30; break;
                }
            }
            switch (material)
            {
                case DesktopMaterial.Oak:
                    price += 200;
                    break;
                case DesktopMaterial.Laminate:
                    price += 100;
                    break;
                case DesktopMaterial.Pine:
                    price += 50;
                    break;
                case DesktopMaterial.Rosewood:
                    price += 300;
                    break;
                case DesktopMaterial.Veneer:
                    price += 125;
                    break;
            }
            return price;
        }

        //private void saveDesk()
        //{
            
        //}

        //private List<DeskQuote> loadFile()
        //{
        //    List<DeskQuote> desks = new List<DeskQuote>();
        //    List<string> content = new List<string>(File.ReadAllText(DeskQuote.file).Split('\n'));

        //    while (content.Count > 0)
        //    {
        //        desks.Add(loadDesk(content));
        //    }

        //}

        //private DeskQuote loadDesk(List<string> fileContent)
        //{
        //    try
        //    {
        //        string customerName; int width = 24, depth = 12, drawers = 1, order = 14;
        //        DateTime date; float price; DesktopMaterial material;
        //        while (fileContent[0] != "}")
        //        {
        //            switch (fileContent[0])
        //            {
        //                case string s when s.Contains("{"):
        //                    break;
        //                case string s when s.Contains("customerName:"):
        //                    customerName = (fileContent[0].Split(':'))[1].Replace("\"", "");
        //                    break;
        //                case string s when s.Contains("width:"):
        //                    width = Int32.Parse((fileContent[0].Split(':'))[1]);
        //                    break;
        //                case string s when s.Contains("depth:"):
        //                    depth = Int32.Parse((fileContent[0].Split(':'))[1]);
        //                    break;
        //                case string s when s.Contains("drawers:"):
        //                    drawers = Int32.Parse((fileContent[0].Split(':'))[1]);
        //                    break;
        //                case string s when s.Contains("order:"):
        //                    order = Int32.Parse((fileContent[0].Split(':'))[1]);
        //                    break;
        //                case string s when s.Contains("material:"):
        //                    material = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), (fileContent[0].Split(':'))[1].Replace("\"", ""));
        //                    break;
        //                case string s when s.Contains("date"):
        //                    date = DateTime.Parse((fileContent[0].Split(':'))[1].Replace("\"", ""));
        //                    break;
        //                case string s when s.Contains("}"):
        //                    fileContent.RemoveAt(0);
        //                    return new DeskQuote(width, depth, drawers, order, material, customerName);
        //                    break;
        //            }
        //            fileContent.RemoveAt(0);
        //        }
                
        //    } catch {
        //    }
        //}

    }
}
