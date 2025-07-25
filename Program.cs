namespace IFellowTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи (от 1 до 4 включительно):");

            int task = int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    randomNumbers();
                    break;

                case 2:
                    repeatingSymbols();
                    break;

                case 3:
                    convertCelcius();
                    break;

                case 4:
                    calculateAngle();
                    break;
            }

            void randomNumbers()
            {
                //1
                //Сформировать и заполнить массив случайным числами и вывести максимальное, минимальное и среднее значение.
                //Для генерации случайного числа использовать метод Math.random(), который возвращает значение в промежутке[0, 1].
                Random randomizer = new Random();
                int arraySize = 100;
                double[] randomArray = new double[arraySize];
                double arraySum = 0;
                double avgArray;
                double maxArray = 0;
                double minArray = 1;
                for (int i = 0; i < arraySize; i++)
                {
                    randomArray[i] = randomizer.Next(0, 101)/100.0 ;
                    arraySum += randomArray[i];
                    if (randomArray[i] < minArray) minArray = randomArray[i];
                    if (randomArray[i] > maxArray) maxArray = randomArray[i];
                }
                //avgArray = randomArray.Average();
                //maxArray = randomArray.Max();
                //minArray = randomArray.Min();
                avgArray = arraySum / arraySize;
                Console.WriteLine("Массив из " +arraySize+ " чисел от 0 до 1.\nМаксимальное: " + maxArray + ", минимальное: " + minArray + ", среднее: " + avgArray);
            }

            void repeatingSymbols()
            {
                //2
                //Написать программу, которая должна найти и вывести повторяющийся символ в слове «Hello»
                string wordToCheck = "Hello";
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in wordToCheck)
                {
                    if (charCount.ContainsKey(c)) charCount[c]++;
                    else charCount.Add(c, 1);
                }
                Console.WriteLine("Повторяющиеся символы в слове " + wordToCheck + ":");
                foreach (char c in charCount.Keys)
                {
                    if (charCount[c] > 1) Console.Write(c + " ");
                }
            }

            void convertCelcius()
            {
                //3
                //Напишите класс BaseConverter для конвертации из градусов по Цельсию в
                //Кельвины, Фаренгейты, и так далее. У метода должен быть метод convert, который
                //и делает конвертацию.
                //При запуске кода должна быть возможность ввести градусы Цельсия и выбора конвертации в Кельвины или Фаренгейты
                Console.WriteLine("Введите градусы Цельсия");
                double degreesCelcius = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 0 для перевода в Кельвины, 1 для перевода в Фаренгейты");
                BaseConverter.DegreeType dT = (BaseConverter.DegreeType)int.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + BaseConverter.convert(dT, degreesCelcius));
            }
            
            void calculateAngle()
            {
                //4
                //Напишите метод, который будет вычислять угол между часовой и минутной стрелками часов. На вход функции подаётся время в виде двух переменных: "hours" и "minutes".
                //Расчет угла производить относительно реального поведения стрелок часов.
                Console.WriteLine("Введите часы");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите минуты");
                int minutes = int.Parse(Console.ReadLine());
                Console.WriteLine("Угол между часовой и минутной стрелками часов: " + timeToAngle(hours, minutes));

            }

            double timeToAngle(int hours, int minutes)
            {
                //один час - это 30 градусов, одна минута для часовой стрелки - 0.5 градуса
                double hoursArrow = 30 * hours + 0.5 * minutes; 
                //одна минута - это 6 градусов
                double minutesArrow = minutes * 6;
                return Math.Abs(hoursArrow-minutesArrow);
            }
        }
    }
}