using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGathering.settings
{   
    [Serializable]
    public class Settings
    {
        public int MinerGearSlot { get; set; }

        public Settings()
        {
            MinerGearSlot = -1;
        }
    }
}
