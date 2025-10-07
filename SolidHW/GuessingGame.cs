namespace SolidHW
{
    /// <summary>
    /// O - Отвечает за основную игровую логику игры 
    /// S - Single Responsibility Principle (SRP) Принцип единственной отвественности 
    /// </summary>
    public class GuessingGame
    {
        private readonly GameSettings _settings;
        private readonly IRandomNumberGenerator _numberGenerator;
        private readonly IGameUI _ui;
        private int _targetNumber;

        public GuessingGame(GameSettings settings, IRandomNumberGenerator generator, IGameUI ui)
        {
            _settings = settings;
            _numberGenerator = generator;
            _ui = ui;
        }

        public void Start()
        {
            _targetNumber = _numberGenerator.Generate(_settings.Min, _settings.Max);
            _ui.ShowMessage($"Угадайте число от {_settings.Min} до {_settings.Max}. У вас {_settings.MaxAttempts} попыток.");

            for (int attempt = 1; attempt <= _settings.MaxAttempts; attempt++)
            {
                int guess = _ui.GetNumber($"Попытка {attempt}: ");

                if (guess == _targetNumber)
                {
                    _ui.ShowMessage("Поздравляем! Вы угадали число!");
                    return;
                }

                if (guess < _targetNumber)
                    _ui.ShowMessage("Загаданное число больше.");
                else
                    _ui.ShowMessage("Загаданное число меньше.");
            }

            _ui.ShowMessage($"Вы проиграли. Загаданное число было: {_targetNumber}");
        }
    }
}
