using System;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab3_Singleton;
using static System.Windows.Forms.MonthCalendar;

namespace WinFormsApp_OOP_Lab3_Singleton.Forms
{
    public partial class EditForm : Form
    {
        private House _house;
        private int _key;

        public EditForm(House house, int key)
        {
            InitializeComponent();
            _house = house;
            _key = key;
            LoadData();
        }

        private void LoadData()
        {
            txtStreet.Text = _house.Street;
            txtCity.Text = _house.City;
            txtYear.Text = _house.YearBuilt.ToString();
            txtApartments.Text = _house.ApartmentsCount.ToString();
            txtValue.Text = _house.Value.ToString();
            txtArea.Text = _house.Area.ToString();
            txtFloors.Text = _house.FloorsCount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Валидация происходит в сеттерах свойств House
                _house.Street = txtStreet.Text;
                _house.City = txtCity.Text;
                _house.YearBuilt = int.Parse(txtYear.Text);
                _house.ApartmentsCount = int.Parse(txtApartments.Text);
                _house.Value = decimal.Parse(txtValue.Text);
                _house.Area = double.Parse(txtArea.Text);
                _house.FloorsCount = int.Parse(txtFloors.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(this.Handle, ex.Message, "Ошибка ввода", 16);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}