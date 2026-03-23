using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_OOP_Lab3_Singleton.Model
{
  public  class HouseAdapter : IHouseInfo
    {
            private readonly House _house;

            public HouseAdapter(House house)
            {
                _house = house;
            }

            public string GetFullInfo()
            {
            return $"Улица: {_house.Street}, " +
        $"Город: {_house.City}, " +
        $"Год: {_house.YearBuilt}, " +
        $"Квартир: {_house.ApartmentsCount}, " +
        $"Стоимость: {_house.Value}, " +  // убираем :C
        $"Площадь: {_house.Area}, " +
        $"Этажей: {_house.FloorsCount}";
        }
        }
    }
