using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace BigJacob.Data
{
    public class JsonSerialiser : ISerialiser
    {
        public void SerialiseToFile<T>(T item, string path) => File.WriteAllText(path, JsonConvert.SerializeObject(item));

        public async Task SerialiseToFileAsync<T>(T item, string path)
        {
            using (var file = new StreamWriter(path))
            {
                await file.WriteAsync(JsonConvert.SerializeObject(item));
            }
        }
    }
}