using IniParser;
using IniParser.Model;

namespace main
{
    public class Settings
    {
        public bool fullScreen;
        public string playerName;
        public string musicVolume;
        public string masterVolume;
        public string forward;
        public string backward;
        public string right;
        public string left;
        public string jump;
        public string interact;
        
        public void readFile()
        {
            
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Settings.ini");
            string useFullScreenStr = data["General"]["fullscreen"];
            bool fullScreen = bool.Parse(useFullScreenStr);
            string playerName = data["General"]["PlayerName"];
            string useMusicVolumeInt = data["Audio"]["MusicVolume"];
            int musicVolume = int.Parse(useMusicVolumeInt);
            string useMasterVolumeInt = data["Audio"]["MasterVolume"];
            int masterVolume = int.Parse(useMasterVolumeInt);
            string useForwardChar = data["Controls"]["Forward"];
            char forward = char.Parse(useForwardChar);
            string useBackwardChar = data["Controls"]["Backward"];
            char backward = char.Parse(useBackwardChar);
            string useLeftChar = data["Controls"]["Left"];
            char left = char.Parse(useLeftChar);
            string useRightChar = data["Controls"]["Right"];
            char right = char.Parse(useRightChar);
            string jump = data["Controls"]["Jump"];
            string useInteractChar = data["Controls"]["Interact"];
            char interact = char.Parse(useInteractChar);
        
        }  
        
    }
}