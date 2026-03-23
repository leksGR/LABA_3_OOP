using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab3_Singleton;
using WinFormsApp_OOP_Lab3_Singleton.Model;

namespace WinFormsApp_OOP_Lab3_Singleton.Forms
{
    public partial class MainForm : Form
    {
        private HouseCollection _collection;

        public MainForm()
        {
            InitializeComponent();
            _collection = HouseCollection.Instance;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewHouses.Rows.Clear();
            dataGridViewHouses.Columns.Clear();

            // Заголовки столбцов
            dataGridViewHouses.Columns.Add("Key", "Ключ");
            dataGridViewHouses.Columns.Add("Street", "Улица");
            dataGridViewHouses.Columns.Add("City", "Город");
            dataGridViewHouses.Columns.Add("Year", "Год постройки");
            dataGridViewHouses.Columns.Add("Apartments", "Квартиры");
            dataGridViewHouses.Columns.Add("Value", "Стоимость");
            dataGridViewHouses.Columns.Add("Area", "Площадь");
            dataGridViewHouses.Columns.Add("Floors", "Этажи");

            // Колонка с информацией через Adapter
            dataGridViewHouses.Columns.Add("FullInfo", "Полная информация (Adapter)");
            dataGridViewHouses.Columns["FullInfo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewHouses.Columns["FullInfo"].MinimumWidth = 300;

            var entries = _collection.GetAllEntries();
            var sortedEntries = entries.OrderBy(e => (int)e.Key).ToArray();

            foreach (DictionaryEntry entry in sortedEntries)
            {
                int key = (int)entry.Key;
                House house = (House)entry.Value;

                IHouseInfo adapter = new HouseAdapter(house);

                dataGridViewHouses.Rows.Add(
                    key,
                    house.Street,
                    house.City,
                    house.YearBuilt,
                    house.ApartmentsCount,
                    house.Value.ToString("C"),
                    house.Area,
                    house.FloorsCount,
                    adapter.GetFullInfo() // использование Adapter
                );
            }
        }

        // Добавление дома по ключу
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numericUpDownKey.Value;

                if (_collection.Table.ContainsKey(key))
                {
                    MessageBox.Show($"Ключ {key} уже существует. Выберите другой ключ.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _collection.AddRandomItem(key);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(this.Handle, ex.Message, "Ошибка", 16);
            }
        }

        // Удаление дома по ключу
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numericUpDownKey.Value;

                if (!_collection.Table.ContainsKey(key))
                {
                    MessageBox.Show($"Ключ {key} не найден.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _collection.Remove(key);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(this.Handle, ex.Message, "Ошибка", 16);
            }
        }

        // Редактирование дома по ключу
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numericUpDownKey.Value;

                if (!_collection.Table.ContainsKey(key))
                {
                    MessageBox.Show($"Ключ {key} не найден.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                House house = (House)_collection.Table[key];

                using (var editForm = new EditForm(house, key))
                {
                    editForm.ShowDialog();
                }
                RefreshGrid();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(this.Handle, ex.Message, "Ошибка", 16);
            }
        }

       
        private void lblKey_Click(object sender, EventArgs e)
        {
            // Заглушка
        }

        private void dataGridViewHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Заглушка
        }
    }
}