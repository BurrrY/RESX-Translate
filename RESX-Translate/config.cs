using System;
using System.IO;

namespace RESX_Translate
{
    public class config
    {
        public static string confFile = "Resx_trans.conf";
        public static string confDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Resx_trans");
    }
}
