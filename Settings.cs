using IniParser;
using IniParser.Model;

namespace main
{
    public class Settings
    {
        public bool consoleDebugScreenDimensions;

        public Settings()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Settings.ini");
            consoleDebugScreenDimensions = bool.Parse(data["ConsoleDebug"]["screen_dimensions"]);
        }

    }
}