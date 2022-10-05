using Custom.Json.Lib;


namespace ConsoleApp11
{

    public class Program
    {
        public static void Main()
        { 
            

            string filePath = Directory.GetCurrentDirectory().Split("bin")[0] + "testdata/demoJson.json";

            JsonLib json = new JsonLib();
            json.loadJson(filePath);
           // Console.WriteLine(json.getJsonSAsString());
          //  json.setItem("Address", "Street 1, satya nagar, hyderabad-200");
           // Console.WriteLine(json.getJsonSAsString());

            json.setKeyValueToArrayItem("map", "mapId","26", "mapName", "Kumar000");





        }

    }

}