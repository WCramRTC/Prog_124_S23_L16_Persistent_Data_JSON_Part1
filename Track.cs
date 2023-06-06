using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L16_Persistent_Data_JSON_Part1
{
    public class Track
    {
        string _trackName;
        double _seconds;

        public Track(string trackName, int seconds)
        {
            _trackName = trackName;
            _seconds = seconds;
        }

        public string TrackName { get => _trackName; set => _trackName = value; }
        public double Seconds { get => _seconds; set => _seconds = value; }

        public string FormattedTime
        {
            get
            {
                int minutes = (int)_seconds / 60;
                int seconds = (int)_seconds % 60;

                return $"{minutes:D2}:{seconds:D2}";


                //TimeSpan t = TimeSpan.FromSeconds(_seconds);

                //return string.Format("{0:D2}:{1:D2}:{2:D2}",
                //                t.Hours,
                //                t.Minutes,
                //                t.Seconds,
                //                t.Milliseconds);

            }
        }

        // Discussion for the future
        // Sample rate - long type?
    }
}
