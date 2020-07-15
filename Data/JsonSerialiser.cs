using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace BigJacob.Data
{
    /// <summary>
    /// Serialises objects into JSON files
    /// </summary>
    public class JsonSerialiser : ISerialiser
    {
        /// <summary>
        /// Serialise an object to a JSON file
        /// </summary>
        /// <typeparam name="T"> Type of object to serialise </typeparam>
        /// <param name="item"> Item to serialise </param>
        /// <param name="path"> Path of file to serialise into </param>
        public void SerialiseToFile<T>(T item, string path) => File.WriteAllText(path, JsonConvert.SerializeObject(item));

        /// <summary>
        /// Asynchronously serialise an object to a JSON file
        /// </summary>
        /// <typeparam name="T"> Type of object to serialise </typeparam>
        /// <param name="item"> Item to serialise </param>
        /// <param name="path"> Path of file to serialise into </param>
        /// <returns> A task </returns>
        public async Task SerialiseToFileAsync<T>(T item, string path)
        {
            using (var file = new StreamWriter(path))
            {
                await file.WriteAsync(JsonConvert.SerializeObject(item));
            }
        }
    }
}