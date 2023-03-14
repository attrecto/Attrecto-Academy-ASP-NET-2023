namespace Academy_2023.Helpers
{
    public class LogLevelHelper
    {
        public string Default { get; set; } = null!;

        [ConfigurationKeyName("Microsoft.AspNetCore")]
        public string AspNetCoreDefault { get; set; } = null!;
    }
}
