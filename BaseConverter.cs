
namespace IFellowTest
{
    internal static class BaseConverter
    {
        //Напишите класс BaseConverter для конвертации из градусов по Цельсию в
        //Кельвины, Фаренгейты, и так далее. У метода должен быть метод convert, который
        //и делает конвертацию.
        //При запуске кода должна быть возможность ввести градусы Цельсия и выбора конвертации в Кельвины или Фаренгейты
        public static double convert(DegreeType type, double degressCelcius)
        {
            switch (type)
            {
                case DegreeType.Kelvin:
                    return degressCelcius+273.15;
                case DegreeType.Farenheit:
                    return degressCelcius*9/5+32;
                default:
                    return -99;
            }
        }

        public enum DegreeType {Kelvin, Farenheit}
    }
}
