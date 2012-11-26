using JetBrains.Annotations;
using Restuta.ConsoleExtensions.Colorfull;

namespace EventStoreObserver.Console
{
    public static class StringExtensions
    {
        [StringFormatMethod("source")]
        public static string F(this string source, params object[] args)
        {
            return string.Format(source, args);
        }

        [StringFormatMethod("source")]
        public static string F(this ColorfulString source, params object[] args)
        {
            return string.Format(source, args);
        }
    }
}