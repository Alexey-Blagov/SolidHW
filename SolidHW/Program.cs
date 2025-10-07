namespace SolidHW
{
    // Основная программа для исполнения 
    // Запуск игры 
    public class Program
    {
        //метод вход 
        public static void Main()
        {
            IGameUI ui = new ConsoleGameUI();

            ui.ShowMessage("Старт игры 'Угадай число'!");

            int min;
            int max;
            int attempts; 

            // Получение корректного диапазона
            while (true)
            {
                min = ui.GetNumber("Введите минимальное число диапазона: ");
                max = ui.GetNumber("Введите максимальное число диапазона: ");

                if (min >= max)
                {
                    ui.ShowMessage("Ошибка: минимальное число должно быть меньше максимального.");
                    continue;
                }

                break;
            }

            // Получение корректного количества попыток
            while (true)
            {
                attempts = ui.GetNumber("Введите максимальное количество попыток: ");
                if (attempts <= 0)
                {
                    ui.ShowMessage("Ошибка: количество попыток должно быть больше 0.");
                    continue;
                }

                break;
            }

            var settings = new GameSettings(min, max, attempts);
            var generator = new RandomNumberGenerator();
            var game = new GuessingGame(settings, generator, ui);

            game.Start();
        }
    }
}
