using System;

namespace WinFormsApp_OOP_Lab3_Singleton
{
    public class RandomGenerator
    {
        private static readonly string[] Streets =
        {
            "Ленина", "Пушкина", "Гагарина", "Советская", "Мира"
        };

        private static readonly string[] Cities =
        {
            "Москва", "Санкт-Петербург", "Екатеринбург", "Казань", "Новосибирск"
        };

        private readonly Random _random = new Random();

        public House CreateRandomHouse()
        {
            return new House(
                street: Streets[_random.Next(Streets.Length)],
                city: Cities[_random.Next(Cities.Length)],
                yearBuilt: _random.Next(1900, 2023),
                apartmentsCount: _random.Next(1, 200),
                value: (decimal)(_random.NextDouble() * 50_000_000),
                area: Math.Round(_random.NextDouble() * 5000 + 100, 2),
                floorsCount: _random.Next(1, 25)
            );
        }
    }
}