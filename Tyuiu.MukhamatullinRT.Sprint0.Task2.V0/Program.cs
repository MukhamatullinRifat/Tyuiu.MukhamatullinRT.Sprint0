using Tyuiu.MukhamatullinRT.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MukhamatullinRT.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библмотеки Tyuiu.MukhamatullinRT.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Рифат"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
