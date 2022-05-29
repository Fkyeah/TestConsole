using System.Text;

namespace TestConsole.ClassLibrary
{
    public class StringMethods
    {
        public string Concate(string a, string b)
        {
            return a + b;
        }

        public string ConcatenationArray(string[] a)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                stringBuilder.Append(a[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
