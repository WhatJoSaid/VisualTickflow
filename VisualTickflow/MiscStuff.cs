using System.Collections.Generic;

namespace VisualTickflow
{
    public static class MiscStuff
    {
        public static Dictionary<string, string> SpaceballSubs; 
        public static bool CheckLen(string[] list, int numcheck)
        {
            if (list.Length == numcheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}