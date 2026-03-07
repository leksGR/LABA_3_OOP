using System;

namespace WinFormsApp_OOP_Lab3_Singleton
{
    public class House
    {
        public static int ObjectsCount { get; private set; } = 0;

        public string Street { get; set; }
        public string City { get; set; }
        public int YearBuilt { get; set; }

        private int _apartmentsCount;
        public int ApartmentsCount
        {
            get => _apartmentsCount;
            set
            {
                if (value < 0)
                    throw new HouseOverflowException(
                        "Количество квартир не может быть отрицательным",
                        $"{nameof(ApartmentsCount)} = {value}");
                _apartmentsCount = value;
            }
        }

        private decimal _value;
        public decimal Value
        {
            get => _value;
            set
            {
                if (value < 0)
                    throw new HouseOverflowException(
                        "Стоимость не может быть отрицательной",
                        $"{nameof(Value)} = {value}");
                _value = value;
            }
        }

        private double _area;
        public double Area
        {
            get => _area;
            set
            {
                if (value <= 0)
                    throw new HouseOverflowException(
                        "Площадь должна быть положительной",
                        $"{nameof(Area)} = {value}");
                _area = value;
            }
        }

        private int _floorsCount;
        public int FloorsCount
        {
            get => _floorsCount;
            set
            {
                if (value <= 0)
                    throw new HouseOverflowException(
                        "Количество этажей должно быть больше 0",
                        $"{nameof(FloorsCount)} = {value}");
                _floorsCount = value;
            }
        }

        public House()
        {
            Street = "Не указано";
            City = "Не указано";
            YearBuilt = 2000;
            ApartmentsCount = 0;
            Value = 0;
            Area = 10;
            FloorsCount = 1;
            ObjectsCount++;
        }

        public House(string street) : this()
        {
            Street = street;
        }

        public House(string street, string city) : this(street)
        {
            City = city;
        }

        public House(
            string street,
            string city,
            int yearBuilt,
            int apartmentsCount,
            decimal value,
            double area,
            int floorsCount) : this(street, city)
        {
            if (yearBuilt <= 0)
                throw new HouseOverflowException(
                    "Год постройки должен быть положительным",
                    $"{nameof(YearBuilt)} = {yearBuilt}");
            if (apartmentsCount < 0)
                throw new HouseOverflowException(
                    "Количество квартир не может быть отрицательным",
                    $"{nameof(ApartmentsCount)} = {apartmentsCount}");
            if (area <= 0)
                throw new HouseOverflowException(
                    "Площадь должна быть положительной",
                    $"{nameof(Area)} = {area}");
            if (floorsCount <= 0)
                throw new HouseOverflowException(
                    "Количество этажей должно быть больше 0",
                    $"{nameof(FloorsCount)} = {floorsCount}");

            YearBuilt = yearBuilt;
            ApartmentsCount = apartmentsCount;
            Value = value;
            Area = area;
            FloorsCount = floorsCount;
        }

        public override string ToString()
        {
            return $"Улица: {Street}\n" +
                   $"Город: {City}\n" +
                   $"Год постройки: {YearBuilt} (HEX: {GetYearBuiltHex()})\n" +
                   $"Квартир: {ApartmentsCount}\n" +
                   $"Стоимость: {Value:C}\n" +
                   $"Площадь: {Area} кв.м\n" +
                   $"Этажей: {FloorsCount}\n" +
                   $"Всего создано объектов: {ObjectsCount}";
        }

        public string GetYearBuiltHex()
        {
            return YearBuilt.ToString("X");
        }
    }
}