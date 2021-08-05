namespace Programatica.Cryptography
{
    public interface IStringCipherService
    {
        string Decrypt(string cipherText);
        string Encrypt(string plainText);
    }
}