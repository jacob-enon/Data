using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace BigJacob.Data
{
    /// <summary>
    /// Deserialises JSON files
    /// </summary>
    public class JsonDeserialiser : IDeserialiser
    {
        /// <summary>
        /// Deserialise a JSON file
        /// </summary>
        /// <typeparam name="T"> Type of object to deserialise into </typeparam>
        /// <param name="path"> Path of file to deserialise </param>
        /// <returns> Deserialised object </returns>
        public T DeserialiseFile<T>(string path) => JsonConvert.DeserializeObject<T>(File.ReadAllText(path));

        /// <summary>
        /// Asynchronously deserialise a JSON file
        /// </summary>
        /// <typeparam name="T"> Type of object to deserialise into </typeparam>
        /// <param name="path"> Path of file to deserialise </param>
        /// <returns> Task of deserialised object </returns>
        public async Task<T> DeserialiseFileAsync<T>(string path)
        {
            string item;
            using (var file = new StreamReader(path))
            {
                item = await file.ReadToEndAsync();
            }
            return JsonConvert.DeserializeObject<T>(item);
        }
    }
}