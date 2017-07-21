using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EasyGathering.settings
{
    public class SettingsManager
    {
        public static Settings load(string filename)
        {
            Settings Loaded_Settings;
            try
            {
                IFormatter format = new BinaryFormatter();
                Stream s = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                Loaded_Settings = (Settings)format.Deserialize(s);
                s.Close();
            } catch(FileNotFoundException e)
            {
                Loaded_Settings = new Settings();
            }
            return Loaded_Settings;
        }

        public static void save(string filename, Settings settings)
        {
            IFormatter format = new BinaryFormatter();
            Stream s = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            format.Serialize(s, settings);
            s.Close();
        }
    }
}
