using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab3_Singleton;

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

        // Добавление случайного дома с ключом из NumericUpDown
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numericUpDownKey.Value;

                // Проверяем, не занят ли ключ
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

        // Удаление по ключу из NumericUpDown
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

        // Редактирование дома по ключу из NumericUpDown
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

        private void btnShowSecondForm_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }

        private void lblKey_Click(object sender, EventArgs e)
        {

        }
    }
}