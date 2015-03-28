using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RESX_Translate
{
    public class Settings
    {
        private static Settings instance = new Settings();
        private bool p;
        public Settings()
        {

        }

        public string workingDir { get; set; }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        public static void Load()
        {
            var serializer = new Polenter.Serialization.SharpSerializer();

            if (File.Exists(Path.Combine(config.confDir, config.confFile)))
                instance = (Settings)serializer.Deserialize(Path.Combine(config.confDir, config.confFile));
            else
                instance = new Settings();
        }


        internal void Save()
        {
            var serializer = new Polenter.Serialization.SharpSerializer();
            serializer.Serialize(instance, Path.Combine(config.confDir, config.confFile));

        }

        public string FilePath { get; set; }

        public string SearchFilePath { get; set; }
    }
}
