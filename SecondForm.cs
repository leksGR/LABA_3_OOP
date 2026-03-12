using System;
using System.Collections;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab3_Singleton;

namespace WinFormsApp_OOP_Lab3_Singleton.Forms
{
    public partial class SecondForm : Form
    {
        private HouseCollection _collection;

        public SecondForm()
        {
            InitializeComponent();
            _collection = HouseCollection.Instance;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewHouses.Rows.Clear();
            dataGridViewHouses.Columns.Clear();

            // Заголовки столбцов (без изменений)
            dataGridViewHouses.Columns.Add("Key", "Ключ");
            dataGridViewHouses.Columns.Add("Street", "Улица");
            dataGridViewHouses.Columns.Add("City", "Город");
            dataGridViewHouses.Columns.Add("Year", "Год постройки");
            dataGridViewHouses.Columns.Add("Apartments", "Квартиры");
            dataGridViewHouses.Columns.Add("Value", "Стоимость");
            dataGridViewHouses.Columns.Add("Area", "Площадь");
            dataGridViewHouses.Columns.Add("Floors", "Этажи");

            var entries = _collection.GetAllEntries();

            // Сортировка по ключу (по возрастанию)
            var sortedEntries = entries.OrderBy(e => (int)e.Key).ToArray();

            foreach (DictionaryEntry entry in sortedEntries)
            {
                int key = (int)entry.Key;
                House house = (House)entry.Value;
                dataGridViewHouses.Rows.Add(
                    key,
                    house.Street,
                    house.City,
                    house.YearBuilt,
                    house.ApartmentsCount,
                    house.Value.ToString("C"),
                    house.Area,
                    house.FloorsCount
                );
            }
        }
    }
}