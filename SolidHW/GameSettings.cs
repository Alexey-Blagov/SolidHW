namespace SolidHW
{
    /// <summary>
    /// S - Single Responsibility Principle (SRP) Принцип единственной отвественности 
    /// </summary>
    public class GameSettings
    {
        public int Min { get; }
        public int Max { get; }
        public int MaxAttempts { get; }

        public GameSettings(int min, int max, int maxAttempts)
        {
            Min = min;
            Max = max;
            MaxAttempts = maxAttempts;
        }
    }
}
