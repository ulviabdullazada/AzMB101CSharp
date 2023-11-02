namespace Exceptions.Exceptions
{
    internal class UserValidationException : Exception
    {
        public UserValidationException()
        {
        }

        public UserValidationException(string? message) : base(message)
        {
        }
    }
}
