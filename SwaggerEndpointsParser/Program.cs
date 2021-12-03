using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace SwaggerEndpointsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputPath;
            //string outputPath;

            //string[] lines = File.ReadAllLines("config.txt");

            Root root;
            using (StreamReader r = new StreamReader("D:/original.json"))
            {
                string json = r.ReadToEnd();
                root = JsonConvert.DeserializeObject<Root>(json);
            }
            var clearPaths = root.paths;
            var routes = clearPaths.Children();

            using (StreamWriter sw = new StreamWriter("D:/parsedEndpoints.txt"))
            { 
                foreach (JProperty x in routes)
                {
                    foreach (JProperty method in x.Children().Children())
                    {
                        sw.WriteLine(method.Name + "\t" + x.Name);
                    }
                };
            }
        }

    }
}
