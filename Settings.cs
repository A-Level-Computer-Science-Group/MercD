using IniParser;
using IniParser.Model;

namespace main
{
    public class Settings
    {
        //These properties should be set to the required value or they will remain default
        public static string isFullscreen { get; set; }
        public static string playerName { get; set; }
        public static string musicVolume { get; set; }
        public static string masterVolume { get; set; }
        public static string forward { get; set; }
        public static string backward { get; set; }
        public static string left { get; set; }
        public static string right { get; set; }
        public static string jump { get; set; }
        public static string interact { get; set; }
    }
    public class OverWrite : Settings
    {
        public static void overWrite(bool overWrite)
        {
            if (overWrite == true)
            {

                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Settings.ini");
                //writing to the .ini file
                data["General"]["PlayerName"] = Settings.playerName;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.playerName 
                and setting it to Player Name in the ini file*/
                data["General"]["FullScreen"] = Settings.isFullscreen;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.isFullscreen 
                and setting it to FullScreen in the ini file*/
                data["General"]["MusicVolume"] = Settings.musicVolume;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.musicVolume 
                and setting it to MusicVolume in the ini file*/
                data["General"]["MasterVolume"] = Settings.masterVolume;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.masterVolume 
                and setting it to MasterVolume in the ini file*/
                data["Audio"]["Forward"] = Settings.forward;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.forward 
                and setting it to Forward in the ini file*/
                data["Audio"]["Backward"] = Settings.backward;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.backward 
                and setting it to Backward in the ini file*/
                data["Controls"]["Left"] = Settings.left;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.left 
                and setting it to Left in the ini file*/
                data["Controls"]["Right"] = Settings.right;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.right 
                and setting it to Right in the ini file*/
                data["Controls"]["Jump"] = Settings.jump;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.jump 
                and setting it to Jump in the ini file*/
                data["Controls"]["Interact"] = Settings.interact;
                parser.WriteFile("Configuration.ini", data);
                /*Taking in the user set property Settings.interact 
                and setting it to Interact in the ini file*/

            }
        }
    }
}
/* string usePlayerNameStr = data["General"]["PlayerName"];
                string useFullScreenBoo = data["General"]["FullScreen"];
                string useMusicVolumeStr = data["Audio"]["MusicVolume"];
                string useMasterVolumeStr = data["Audio"]["MasterVolume"];
                string useForwardStr = data["Controls"]["Forward"];
                string useBackwardStr = data["Controls"]["Backward"];
                string useLeftStr = data["Controls"]["Left"];
                string useRightStr = data["Controls"]["Right"];
                string useJumpStr = data["Controls"]["Jump"];
                string useInteractStr = data["Controls"]["Interact"];*/
//add this code later on when trying to read from the ini file and execute the value in the main programr
