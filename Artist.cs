using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L16_Persistent_Data_JSON_Part1
{
    public class Artist
    {
        string _name;

        public Artist(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
