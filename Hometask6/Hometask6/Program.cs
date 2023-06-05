namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] directories = Directory.GetDirectories("C:\\New folder\\","book*");
            foreach(string d in directories) 
            {
                Console.WriteLine(d);
            }
        }
    }
}