using IniParser;
using IniParser.Model;

namespace main
{
    public class Settings
    {
        public Settings()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Settings.ini");
            string useFullScreenStr = data["General"]["fullscreen"];
            bool useFullScreen = bool.Parse(useFullScreenStr);
            string usePlayerName = data["General"]["PlayerName"];
            string useMusicVolumeInt = data["Audio"]["MusicVolume"];
            int useMusicVolume = int.Parse(useMusicVolumeInt);
            string useMasterVolumeInt = data["Audio"]["MasterVolume"];
            int useMasterVolume = int.Parse(useMasterVolumeInt);
            string useForwardChar = data["Controls"]["Forward"];
            char useForward = char.Parse(useForwardChar);
            string useBackwardChar = data["Controls"]["Backward"];
            char useBackward = char.Parse(useBackwardChar);
            string useLeftChar = data["Controls"]["Left"];
            char useLeft = char.Parse(useLeftChar);
            string useRightChar = data["Controls"]["Right"];
            char useRight = char.Parse(useRightChar);
            string useJump = data["Controls"]["Jump"];
            string useInteractChar = data["Controls"]["Interact"];
            char useInteract = char.Parse(useInteractChar);
        }  
    }
}