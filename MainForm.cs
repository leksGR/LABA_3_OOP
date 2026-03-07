using System;
using System.Collections;
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

            // Заголовки столбцов
            dataGridViewHouses.Columns.Add("Key", "Ключ");
            dataGridViewHouses.Columns.Add("Street", "Улица");
            dataGridViewHouses.Columns.Add("City", "Город");
            dataGridViewHouses.Columns.Add("Year", "Год постройки");
            dataGridViewHouses.Columns.Add("Apartments", "Квартиры");
            dataGridViewHouses.Columns.Add("Value", "Стоимость");
            dataGridViewHouses.Columns.Add("Area", "Площадь");
            dataGridViewHouses.Columns.Add("Floors", "Этажи");

            var entries = _collection.GetAllEntries();
            foreach (DictionaryEntry entry in entries)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int newKey = _collection.GetItemCount(); // простой способ: следующий индекс
                _collection.AddRandomItem(newKey);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(this.Handle, ex.Message, "Ошибка", 16);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numericUpDownKey.Value;
                _collection.Remove(key);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(this.Handle, ex.Message, "Ошибка", 16);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewHouses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите дом для редактирования.");
                return;
            }

            int key = (int)dataGridViewHouses.SelectedRows[0].Cells["Key"].Value;
            House house = (House)_collection.Table[key];

            using (var editForm = new EditForm(house, key))
            {
                editForm.ShowDialog();
            }
            RefreshGrid();
        }

        private void btnShowSecondForm_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }
    }
}