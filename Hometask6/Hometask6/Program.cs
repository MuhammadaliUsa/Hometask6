namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:/Newfolder";
            string result = Check(path);
            Console.WriteLine(result);

            
         

        }
        public static string Check(string path)
        {
            if (!Directory.Exists(path))
                return "Path mavjud emas";

            if (Directory.GetDirectories(path).Length > 0 && Directory.GetFiles(path).Length > 0)
                return "Papka va fayllar bor";
            else if (Directory.GetDirectories(path).Length > 0)
                return "Papkalar bor";
            else if (Directory.GetFiles(path).Length > 0)
                return "Fayllar bor";
            else
                return "Papka bo'sh";
        }
    }
}