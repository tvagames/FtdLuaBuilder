using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaBuilder
{
    public class Config
    {
        public string SeedDir { get; set; }
        public string LibDir { get; set; }
        public string OutputDir { get; set; }
        public bool IsAllBuild { get; set; }
        public bool IsStartup { get; set; }
        public bool IsClipNotify { get; set; }

        internal void Save()
        {
            using (var sw = new System.IO.StreamWriter("LuaBuilder_config.xml"))
            {
                var ser = new System.Xml.Serialization.XmlSerializer(typeof(Config));
                ser.Serialize(sw, this);
            }
        }

        internal static Config Load()
        {
            try
            {
                using (var sw = new System.IO.StreamReader("LuaBuilder_config.xml"))
                {
                    var ser = new System.Xml.Serialization.XmlSerializer(typeof(Config));
                    return (Config)ser.Deserialize(sw);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
