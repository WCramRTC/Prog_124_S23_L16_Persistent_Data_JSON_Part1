using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L16_Persistent_Data_JSON_Part1
{
    internal class CompactDisc
    {

        string _title;
        Artist _artist;
        int _numberOfTracks;
        List<Track> _tracks;
        bool _bonusTrack;

        public CompactDisc() { } // Default Constructor

        public CompactDisc(string title, Artist artist, bool bonusTrack)
        {
            _title = title;
            _artist = artist;
            _tracks = new List<Track>();
            _bonusTrack = bonusTrack;
        }

        public string Title { get => _title; set => _title = value; }
        public int NumberOfTracks { get => _tracks.Count;  }
        public bool BonusTrack { get => _bonusTrack; set => _bonusTrack = value; }
        public Artist Artist { get => _artist; set => _artist = value; }
        public List<Track> Tracks { get => _tracks; }

        public void AddTrack(Track track)
        {
            _tracks.Add(track);
        }

        public override string ToString()
        {
            return $"" +
                $"Artist Name: {_artist.Name}\n" +
                $"Album: {_title}\n" +
                $"Number of Tracks {_numberOfTracks}";
        }
    } // class

} // namespace
