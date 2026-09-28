using Tyuiu.MukhamatullinRT.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MukhamatullinRT.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Рифат";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.Equal("Привет..., Рифат", res);
        }
    }
}