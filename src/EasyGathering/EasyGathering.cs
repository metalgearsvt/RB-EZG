using Buddy.Coroutines;
using EasyGathering.database;
using EasyGathering.settings;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using System.Threading.Tasks;
using System.Windows.Media;
using TreeSharp;

namespace EasyGathering
{
    class EasyGatheringBot
    {
        private Composite _root;

        public static class Globals
        {
            public static string BOT_NAME = "EasyGathering";
            public static string SETTINGS_FILE = "settings.bin";
            public static LocationManager LocMan = new LocationManager();
            public static Properties.Saved set = new Properties.Saved();
        }

        public SetWin sw = new SetWin();

        public void OnButtonPress()
        {
            // Button settings here.
            sw.Show();
            Logging.Write(Globals.set.Testing);
        }
        
        public void Initialize()
        {
            Logging.Write(Colors.Lime, $"Initializing {Globals.BOT_NAME}");
        }

        public void Start()
        {
            _root = new ActionRunCoroutine(r => Gather());
            Logging.Write(Colors.Green, $"{Globals.BOT_NAME} started.");
        }

        public void Stop()
        {
            Logging.Write(Colors.Red, $"Stopping {Globals.BOT_NAME}.");
        }

        private async Task<bool> Gather()
        {
            while (true)
            {
                await Coroutine.Sleep(2000);
            }
        }

        public bool IsAutonomous => true;

        public bool RequiresProfile => false;

        public bool WantButton => true;

        public string Name => Globals.BOT_NAME;

        public string EnglishName => Globals.BOT_NAME;

        public PulseFlags PulseFlags => PulseFlags.All;

        public Composite get_Root()
        {
                return _root;
        }
    }
}
