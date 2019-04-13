using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public static class GlobalProperties
    {
        public static bool darkMode = false;

        public static void setDarkMode(bool value)
        {
            darkMode = value;
        }

        public static bool getDarkMode()
        {
            return darkMode;
        }

    }
}
