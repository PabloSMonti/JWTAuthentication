using System.Text;

namespace Authenticator.Tools
{
    public static class SetupWizard
    {
        public static byte[] GetKeyBytes(IConfiguration config, string keySide)
        {
            var key = config.GetValue<string>(keySide);
            var keyBytes = Encoding.ASCII.GetBytes(key!);
            return keyBytes;
        }
    }
}
