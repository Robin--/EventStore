using System;

namespace EventStore.TestClient.Commands.DvuBasic
{
    public static class StreamNamesGenerator
    {
        public static string GenerateName(string original, int index)
        {
            return string.Format("{0}-{1}", original, index);
        }

        public static string GetOriginalName(string autogenerated)
        {
            return autogenerated.Substring(0, autogenerated.LastIndexOf('-'));
        }
    }
}