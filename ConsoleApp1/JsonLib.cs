using Newtonsoft.Json.Linq;
using Newtonsoft.Json; 

namespace Custom.Json.Lib
{
    public class JsonLib
    {

        //usage
        private string filePath; 
        private JObject json;
        private string jsonString;
        private dynamic dynamicJsonObj;
        

        public JsonLib()
        { 
            this.jsonString = @"{}"; 
            this.json = JObject.Parse("{}");

        }  

        public  void loadJson(string path)
        {
            this.filePath = path;
            
            if (File.Exists(this.filePath))
            {
                this.jsonString = File.ReadAllText(this.filePath);
            }
            else
            {
                this.jsonString = @"{}";
            }
            this.json = JObject.Parse(this.jsonString);
        }
         
        public  void saveToJsonFile()
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(this.json, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.filePath, output);
        }  
        private void saveToFile(object jsonData)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.filePath, output);
        }

        public JObject  getJsonObject()
        {
            return this.json;
        }

        public  string getJsonSAsString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this.json , Newtonsoft.Json.Formatting.Indented);
        }
        private object getDynamicJsonObj()
        {
            return JsonConvert.DeserializeObject<dynamic>(this.getJsonObject().ToString());
        }
        public void setItem(string key,string value)
        {
            dynamicJsonObj = this.getDynamicJsonObj();
            dynamicJsonObj[key] = value; 
            this.saveToFile(dynamicJsonObj);
            this.loadJson(this.filePath);

        }
        public string getItem(string key)
        {
            return (string)this.json[key]; 

        }

    }
}
