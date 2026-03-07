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
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtApartments = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtFloors = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblApartments = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFloors = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblStreet
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(12, 15);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 17);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Улица:";

            // txtStreet
            this.txtStreet.Location = new System.Drawing.Point(100, 12);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(150, 22);
            this.txtStreet.TabIndex = 1;

            // lblCity
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 45);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 17);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Город:";

            // txtCity
            this.txtCity.Location = new System.Drawing.Point(100, 42);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 22);
            this.txtCity.TabIndex = 3;

            // lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 75);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(34, 17);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Год:";

            // txtYear
            this.txtYear.Location = new System.Drawing.Point(100, 72);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 22);
            this.txtYear.TabIndex = 5;

            // lblApartments
            this.lblApartments.AutoSize = true;
            this.lblApartments.Location = new System.Drawing.Point(12, 105);
            this.lblApartments.Name = "lblApartments";
            this.lblApartments.Size = new System.Drawing.Size(66, 17);
            this.lblApartments.TabIndex = 6;
            this.lblApartments.Text = "Квартиры:";

            // txtApartments
            this.txtApartments.Location = new System.Drawing.Point(100, 102);
            this.txtApartments.Name = "txtApartments";
            this.txtApartments.Size = new System.Drawing.Size(150, 22);
            this.txtApartments.TabIndex = 7;

            // lblValue
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 135);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(76, 17);
            this.lblValue.TabIndex = 8;
            this.lblValue.Text = "Стоимость:";

            // txtValue
            this.txtValue.Location = new System.Drawing.Point(100, 132);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(150, 22);
            this.txtValue.TabIndex = 9;

            // lblArea
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 165);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(63, 17);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Площадь:";

            // txtArea
            this.txtArea.Location = new System.Drawing.Point(100, 162);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(150, 22);
            this.txtArea.TabIndex = 11;

            // lblFloors
            this.lblFloors.AutoSize = true;
            this.lblFloors.Location = new System.Drawing.Point(12, 195);
            this.lblFloors.Name = "lblFloors";
            this.lblFloors.Size = new System.Drawing.Size(49, 17);
            this.lblFloors.TabIndex = 12;
            this.lblFloors.Text = "Этажи:";

            // txtFloors
            this.txtFloors.Location = new System.Drawing.Point(100, 192);
            this.txtFloors.Name = "txtFloors";
            this.txtFloors.Size = new System.Drawing.Size(150, 22);
            this.txtFloors.TabIndex = 13;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(30, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(130, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // EditForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFloors);
            this.Controls.Add(this.lblFloors);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtApartments);
            this.Controls.Add(this.lblApartments);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.Text = "Редактирование дома";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}