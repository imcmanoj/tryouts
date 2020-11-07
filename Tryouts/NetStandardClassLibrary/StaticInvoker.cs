namespace NetStandardClassLibrary
{
    /// <summary>
    /// Class that has methods which has static method calls
    /// </summary>
    public class StaticInvoker
    {
        /// <summary>
        /// Get method that calls a static method
        /// </summary>
        /// <returns>Message returned from a static method</returns>
        public string Get()
        {
            return CallStaticMethod();
        }

        /// <summary>
        /// Protected method that makes the actual call to static method
        /// </summary>
        /// <returns>Message returned from static method</returns>
        protected virtual string CallStaticMethod()
        {
            return StaticClass.StaticMethod1($"Called from {nameof(StaticInvoker.CallStaticMethod)}");
        }
    }
}
