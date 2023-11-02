namespace Exceptions.Exceptions
{
    internal class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException()
        {
        }

        public UserAlreadyExistException(string? message) : base(message)
        {
        }
    }
}
