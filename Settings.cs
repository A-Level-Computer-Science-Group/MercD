using IniParser;
using IniParser.Model;

namespace main
{
    public class Settings
    {
        public bool fullScreen;
        public string playerName;
        public int musicVolume;
        public int masterVolume;
        public char forward;
        public char backward;
        public char right;
        public char left;
        public string jump;
        public char interact;
        
        public void readFile()
        {
            
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Settings.ini");
            string useFullScreenStr = data["General"]["fullscreen"];
            fullScreen = bool.Parse(useFullScreenStr);
            string playerName = data["General"]["PlayerName"];
            string useMusicVolumeInt = data["Audio"]["MusicVolume"];
            musicVolume = int.Parse(useMusicVolumeInt);
            string useMasterVolumeInt = data["Audio"]["MasterVolume"];
            masterVolume = int.Parse(useMasterVolumeInt);
            string useForwardChar = data["Controls"]["Forward"];
            forward = char.Parse(useForwardChar);
            string useBackwardChar = data["Controls"]["Backward"];
            backward = char.Parse(useBackwardChar);
            string useLeftChar = data["Controls"]["Left"];
            left = char.Parse(useLeftChar);
            string useRightChar = data["Controls"]["Right"];
            right = char.Parse(useRightChar);
            string jump = data["Controls"]["Jump"];
            string useInteractChar = data["Controls"]["Interact"];
            interact = char.Parse(useInteractChar);
        
        }  
        
    }
}