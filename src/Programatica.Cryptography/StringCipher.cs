using Microsoft.AspNetCore.DataProtection;

namespace Programatica.Cryptography
{
    public class StringCipherService : IStringCipherService
    {
        private const string Purpose = "4858055718878509223360720679625487535120";
        private readonly IDataProtectionProvider _provider;

        public StringCipherService(IDataProtectionProvider provider)
        {
            _provider = provider;
        }

        public string Encrypt(string plainText)
        {
            var protector = _provider.CreateProtector(Purpose);
            return protector.Protect(plainText);
        }

        public string Decrypt(string cipherText)
        {
            var protector = _provider.CreateProtector(Purpose);
            return protector.Unprotect(cipherText);
        }
    }
}
