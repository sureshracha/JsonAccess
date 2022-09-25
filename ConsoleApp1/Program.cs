using Custom.Json.Lib;


namespace ConsoleApp11
{

    public class Program
    {
        public static void Main()
        { 
            string filePath = @"C:\Users\sures\Desktop\demoJson.json"; 

            JsonLib json = new JsonLib();
            json.loadJson(filePath);
            Console.WriteLine(json.getJsonSAsString());
            json.setItem("lastName", "kuamraaaass");
            Console.WriteLine(json.getJsonSAsString());
            json.saveToJsonFile();
            Console.WriteLine(json.getItem("firstName"));
           

             

        }

    }

}