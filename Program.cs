using System.Text.Json;

namespace Prog_124_S23_L16_Persistent_Data_JSON_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaveJSON();
        } // Main

        public static void SaveJSON()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string[] names = { "Henry", "Cirella", "Meili" };
            int[] grades = { 110, 120, 130 };

            string jsonManager = JsonSerializer.Serialize(grades, jso);

            Console.WriteLine(jsonManager);

            //File.WriteAllText(Data.userFilePath, jsonManager);
        }


    } // class

} // namespace