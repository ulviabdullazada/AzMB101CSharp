using System.Security.Cryptography;
using System.Text;

namespace AdoNetUser.Helpers;

public static class HashHelper
{
    const int keySize = 64;
    const int iterations = 350000;
    public static string HashSHA512(this string password, out byte[] salt)
    {
        salt = RandomNumberGenerator.GetBytes(keySize);
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            iterations,
            HashAlgorithmName.SHA512,
            keySize);
        return Convert.ToHexString(hash);
    }
    public static string HashSHA512(this string password, string salt)
    {
        var byteSalt = Encoding.ASCII.GetBytes(salt);
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            byteSalt,
            iterations,
            HashAlgorithmName.SHA512,
            keySize);
        return Convert.ToHexString(hash);
    }
}
