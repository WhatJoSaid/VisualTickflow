namespace VisualTickflow
{
    public static class MiscStuff
    {
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