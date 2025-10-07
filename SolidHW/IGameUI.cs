namespace SolidHW
{
    /// <summary>
    /// D - Dependency Inversion Principle (DIP) Принцип инверсии зависимостей 
    /// I - Interface Segregation Principle (ISP) Принцип разделения интерфейса 
    /// </summary>
    public interface IGameUI
    {
        void ShowMessage(string message);
        int GetNumber(string prompt);
    }
}
