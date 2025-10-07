namespace SolidHW
{
    /// <summary>
    /// S - Single Responsibility Principle (SRP) Принцип единственной отвественности 
    /// </summary>
    public interface IRandomNumberGenerator
    {
        int Generate(int min, int max);
    }
}
