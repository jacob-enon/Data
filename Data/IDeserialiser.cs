using System.Threading.Tasks;

namespace BigJacob.Data
{
    /// <summary>
    /// Deserialises files
    /// </summary>
    public interface IDeserialiser
    {
        /// <summary>
        /// Deserialise a file
        /// </summary>
        /// <typeparam name="T"> Type of object to deserialise into </typeparam>
        /// <param name="path"> Path of file to deserialise </param>
        /// <returns> Deserialised object </returns>
        T DeserialiseFile<T>(string path);

        /// <summary>
        /// Asynchronously deserialise a file
        /// </summary>
        /// <typeparam name="T"> Type of object to deserialise into </typeparam>
        /// <param name="path"> Path of file to deserialise </param>
        /// <returns> Task of deserialised object </returns>
        Task<T> DeserialiseFileAsync<T>(string path);
    }
}