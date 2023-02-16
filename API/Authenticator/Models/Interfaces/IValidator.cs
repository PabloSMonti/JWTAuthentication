namespace Authenticator.Models.Interfaces
{
    public interface IValidator<T>
    {
        public static bool IsValid(T value) => false;
    }
}