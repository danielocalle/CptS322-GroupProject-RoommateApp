namespace RoommateAppLibrary
{
    public class Preferences
    {
        public bool? isQuiet { get; set; }
        public bool? hasPets { get; set; }
        public bool? earlyRiser { get; set; }
        public bool? stayUpLate { get; set; }
        public bool? spentTimeRoommate { get; set; }
        public bool? CommonAreaTidy { get; set; }

        public Preferences() { }

        public Preferences(string prefs)
        {
            if (prefs == null || prefs.Length < 6)
            {
                return;
            }

            if (prefs[0] == '1') isQuiet = true;
            else isQuiet = false;

            if (prefs[1] == '1') hasPets = true;
            else hasPets = false;

            if (prefs[2] == '1') earlyRiser = true;
            else earlyRiser = false;

            if (prefs[3] == '1') stayUpLate = true;
            else stayUpLate = false;

            if (prefs[4] == '1') spentTimeRoommate = true;
            else spentTimeRoommate = false;

            if (prefs[5] == '1') CommonAreaTidy = true;
            else CommonAreaTidy = false;
        }

        public string ConvertPreferencesToString()
        {
            if (isQuiet == null || hasPets == null || earlyRiser == null || stayUpLate == null || spentTimeRoommate == null || CommonAreaTidy == null)
            {
                return string.Empty;
            }

            string preferences = (bool)(isQuiet) ? "1" : "0";
            preferences += (bool)(hasPets) ? "1" : "0";
            preferences += (bool)(earlyRiser) ? "1" : "0";
            preferences += (bool)(stayUpLate) ? "1" : "0";
            preferences += (bool)(spentTimeRoommate) ? "1" : "0";
            preferences += (bool)(CommonAreaTidy) ? "1" : "0";

            return preferences;
        }

    }
}
