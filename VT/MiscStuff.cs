using System.Collections.Generic;

namespace VT
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