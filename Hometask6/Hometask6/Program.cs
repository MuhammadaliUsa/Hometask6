namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\New folder\\.gitignore";
            if (File.Exists(file))
            {
                Console.WriteLine("has");
            }
            else
            {
                File.Create(file);
            }
        }
    }
}