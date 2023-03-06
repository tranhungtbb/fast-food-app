using FastFootApp.Debugging;

namespace FastFootApp
{
    public class FastFootAppConsts
    {
        public const string LocalizationSourceName = "FastFootApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3ca401f672334b2698e2fa2b1ba61970";
    }
}
