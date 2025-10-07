namespace SolidHW
{
    /// <summary>
    /// O - Open/Closed Principle (OCP) Принцип открытости/закрытости 
    /// </summary>
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random _random = new Random();

        public int Generate(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
