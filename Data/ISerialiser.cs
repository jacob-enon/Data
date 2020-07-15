using System.Threading.Tasks;

namespace BigJacob.Data
{
    /// <summary>
    /// Serialises objects
    /// </summary>
    public interface ISerialiser
    {
        /// <summary>
        /// Serialise an object into a file
        /// </summary>
        /// <typeparam name="T"> Type of object to serialise </typeparam>
        /// <param name="item"> Item to serialise </param>
        /// <param name="path"> File path to serialise into </param>
        void SerialiseToFile<T>(T item, string path);

        /// <summary>
        /// Asynchronously serialise an object into a file
        /// </summary>
        /// <typeparam name="T"> Type of object to serialise </typeparam>
        /// <param name="item"> Item to serialise </param>
        /// <param name="path"> File path to serialise into </param>
        /// <returns> A task </returns>
        Task SerialiseToFileAsync<T>(T item, string path);
    }
}