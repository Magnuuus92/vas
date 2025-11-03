namespace magnusclass
{
    public static class LsCommand
    {
        public static void Run(string path = "")
        {
            if (string.IsNullOrEmpty(path))
                path = Directory.GetCurrentDirectory();
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (var dir in directories)
            {
                Console.WriteLine($"[DIR] {Path.GetFileName(dir)}");
            }
            foreach (var file in files)
            {
                Console.WriteLine($" {Path.GetFileName(file)}");
            }
        }


    }
    public static class CatCommand
    {
        public static void Run(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found: {filePath}");
                return;
            }
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
    }
}