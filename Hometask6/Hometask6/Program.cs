namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] directories = Directory.GetDirectories("C:\\New folder\\","bin*");
            foreach(string d in directories) 
            {
                Console.WriteLine(d);
            }
            string[] directories1 = Directory.GetDirectories("C:\\New folder\\", "obj*");
            foreach (string d1 in directories1)
            {
                Console.WriteLine(d1);
            }
        }
    }
}