using vanson.Debugging;

namespace vanson
{
    public class vansonConsts
    {
        public const string LocalizationSourceName = "vanson";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "877e8c042b9d48ffa46e6e5401fe2a01";
    }
}
