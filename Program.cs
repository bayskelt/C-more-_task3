using System.Reflection;

namespace C__more__task3
{
    // Абстрактний базовий клас
    abstract class HeavenlyBody
    {
        public abstract void ReportAboutMovement();
        public abstract void ReportAboutLife();
    }

    // Похідний клас Земля
    class Earth : HeavenlyBody
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Земля обертається навколо Сонця.");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine("На Землi є життя.");
        }
    }

    // Похідний клас Місяць
    class Moon : HeavenlyBody
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Мiсяць обертається навколо Землi.");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine("На Мiсяцi життя не виявлено.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            // Масив об'єктів типу HeavenlyBody
            HeavenlyBody[] celestialBodies = new HeavenlyBody[2];

            // Створення об'єктів
            celestialBodies[0] = new Earth();
            celestialBodies[1] = new Moon();

            // Виклик методів через цикл
            foreach (HeavenlyBody body in celestialBodies)
            {
                body.ReportAboutMovement();
                body.ReportAboutLife();
            }
        }
    }
}
