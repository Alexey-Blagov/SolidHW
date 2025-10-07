namespace SolidHW
{
    /// <summary>
    /// O, D - позволяет расширять (например, добавить GUI реализацию)  Принцип открытости/закрытости 
    /// </summary>
    public class ConsoleGameUI : IGameUI
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Метд проверки корретности на вввод данных 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public int GetNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Пустой ввод. Пожалуйста, введите число.");
                    continue;
                }

                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Ошибка ввода. Введите корректное целое число.");
                    continue;
                }

                return number;
            }
        }
    }
}
