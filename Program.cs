using System.Text.Json;
using System.IO;

namespace Prog_124_S23_L16_Persistent_Data_JSON_Part1
{
    internal class Program
    {

        static string filePath = "cds.json";
        static List<CompactDisc> cds = new List<CompactDisc>();

        static void Main(string[] args)
        {
            //SaveJSON();
            //Preload();
            LoadJson();

            foreach (CompactDisc cd in cds)
            {
                Console.WriteLine(cd.ToString());
            }

            Console.WriteLine(cds.Count.ToString());

        } // Main

        public static void Preload()
        {
            cds = new List<CompactDisc>()
            {
                new CompactDisc("Beatrice",
                new Artist("Tsukino"),
                false
                ),
                 new CompactDisc("Spice",
                new Artist("Spice Girls"),
                false
                )
                //new CompactDisc("The Sign", "Ace of Base", 13, false),
                //new CompactDisc("Beatrice", "Tsukino", 8, false),
                //new CompactDisc("Fooly Cooly Soundtrack", "The Pillows", 21, true ),
                //new CompactDisc("Graduation", "Kanye", 14, true),
                //new CompactDisc("Spice", "Spice Girls", 10, false),
                //new CompactDisc("Red: Disc C", "Redalice, ARM, Masayoshi Minishima, Kaztora, T+Pazolite, NYO, D.Watt, Sound Holic, 8Style, Morrigan, Syrufit, Nekono, Estha, (Name not in the roman alphabet, how do I write this?)", 15, false)
            };

            cds[0].AddTrack(new Track("Akumanowarai", 58));
            cds[0].AddTrack(new Track("Harlot Babylon", 289));

            cds[1].AddTrack(new Track("Wannabe", 173));
            cds[1].AddTrack(new Track("Say You'll Be There", 236));
        } // Preload()

        public static void SaveJSON()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonManager = JsonSerializer.Serialize(cds, jso);
            File.WriteAllText(filePath, jsonManager);

            //Console.WriteLine(jsonManager);

            //Track sayYoullBeThere = new Track("Say You'll Be There", 236);
            Console.WriteLine(jsonManager);

        }

        public static void LoadJson()
        {
            string listFromFile = File.ReadAllText(filePath);
            cds = JsonSerializer.Deserialize<List<CompactDisc>>(listFromFile);
        }

        

    } // class

} // namespace