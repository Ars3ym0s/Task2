namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Если копируете путь то уберите ковычки)");
            Console.Write("Введите путь файла: ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не найден");
                return;
            }

            string fileContents = File.ReadAllText(filename);
            string[] words = fileContents.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Количество слов: {0}", words.Length);
        }
    }
}