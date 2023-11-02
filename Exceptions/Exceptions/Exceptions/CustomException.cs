namespace Exceptions.Exceptions
{
    internal class CustomException : Exception
    {
        public CustomException() : base("Custom Exception bash verdi")
        {
        }
        public CustomException(string message) : base(message)
        {
        }
    }
}
