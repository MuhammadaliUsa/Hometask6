namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\New folder";
            string[] isBin = Directory.GetDirectories(path, "bin*.");
            foreach (string bin in isBin)
            {
                Console.WriteLine(bin + "  Deleted");
                Directory.Delete(bin, true);
            }
            string[] isObj = Directory.GetDirectories(path, "obj*.");
            foreach (string obj in isObj)
            {
                Console.WriteLine(obj + "  Deleted");
                Directory.Delete(obj, true);
            }
        }
    }
}