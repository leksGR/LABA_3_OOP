namespace WinFormsApp_OOP_Lab3_Singleton.Forms
{
    partial class EditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtApartments;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtFloors;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblApartments;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFloors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtYear = new TextBox();
            txtApartments = new TextBox();
            txtValue = new TextBox();
            txtArea = new TextBox();
            txtFloors = new TextBox();
            lblStreet = new Label();
            lblCity = new Label();
            lblYear = new Label();
            lblApartments = new Label();
            lblValue = new Label();
            lblArea = new Label();
            lblFloors = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(100, 15);
            txtStreet.Margin = new Padding(3, 4, 3, 4);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(150, 27);
            txtStreet.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(100, 52);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 27);
            txtCity.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(100, 90);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 27);
            txtYear.TabIndex = 5;
            // 
            // txtApartments
            // 
            txtApartments.Location = new Point(100, 128);
            txtApartments.Margin = new Padding(3, 4, 3, 4);
            txtApartments.Name = "txtApartments";
            txtApartments.Size = new Size(150, 27);
            txtApartments.TabIndex = 7;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(100, 165);
            txtValue.Margin = new Padding(3, 4, 3, 4);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(150, 27);
            txtValue.TabIndex = 9;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(100, 202);
            txtArea.Margin = new Padding(3, 4, 3, 4);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(150, 27);
            txtArea.TabIndex = 11;
            // 
            // txtFloors
            // 
            txtFloors.Location = new Point(100, 240);
            txtFloors.Margin = new Padding(3, 4, 3, 4);
            txtFloors.Name = "txtFloors";
            txtFloors.Size = new Size(150, 27);
            txtFloors.TabIndex = 13;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(12, 19);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(55, 20);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Улица:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 56);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(54, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "Город:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(12, 94);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(36, 20);
            lblYear.TabIndex = 4;
            lblYear.Text = "Год:";
            // 
            // lblApartments
            // 
            lblApartments.AutoSize = true;
            lblApartments.Location = new Point(12, 131);
            lblApartments.Name = "lblApartments";
            lblApartments.Size = new Size(81, 20);
            lblApartments.TabIndex = 6;
            lblApartments.Text = "Квартиры:";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(12, 169);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(86, 20);
            lblValue.TabIndex = 8;
            lblValue.Text = "Стоимость:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(12, 206);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(76, 20);
            lblArea.TabIndex = 10;
            lblArea.Text = "Площадь:";
            // 
            // lblFloors
            // 
            lblFloors.AutoSize = true;
            lblFloors.Location = new Point(12, 244);
            lblFloors.Name = "lblFloors";
            lblFloors.Size = new Size(55, 20);
            lblFloors.TabIndex = 12;
            lblFloors.Text = "Этажи:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 288);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 38);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(151, 288);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 38);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 350);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFloors);
            Controls.Add(lblFloors);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(txtValue);
            Controls.Add(lblValue);
            Controls.Add(txtApartments);
            Controls.Add(lblApartments);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtStreet);
            Controls.Add(lblStreet);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "EditForm";
            Text = "Редактирование дома";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}