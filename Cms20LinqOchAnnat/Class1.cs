namespace Cms20LinqOchAnnat
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            string[] userString = str.Split(' ');
            int wordCount = userString.Length;
            return wordCount;
        }
    }
}