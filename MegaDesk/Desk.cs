using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public static class Constants
    {
        public static readonly Dictionary<string, int> order = new Dictionary<string, int>
        {
            {"None", 14},
            {"7 Days",7},
            {"5 Days",5},
            {"3 Days",3}
        };
    }
    internal class Desk
    {
        public const int widthMin = 24;
        public const int widthMax = 96;
        public const int depthMin = 12;
        public const int depthMax = 48;
        public const int drawerMin = 0;
        public const int drawerMax = 7;

    }
}
