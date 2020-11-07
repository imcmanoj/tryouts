namespace NetStandardClassLibrary
{
    /// <summary>
    /// Static class
    /// </summary>
    public class StaticClass
    {
        /// <summary>
        /// Static method that takes string as a input
        /// </summary>
        /// <param name="message">Input to be returned with appended text message</param>
        /// <returns>Appended text message</returns>
        public static string StaticMethod1(string message)
        {
            return $"Hi, Message received as - {message}";
        }
    }
}
