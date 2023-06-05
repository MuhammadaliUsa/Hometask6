namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("C:\\New folder\\", "*.txt");
            foreach (string file in files) 
            {
                string fullName=Path.GetFileName(file);
                Console.WriteLine(fullName);
            }
        }
    }
}