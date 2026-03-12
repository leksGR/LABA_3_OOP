namespace WinFormsApp_OOP_Lab3_Singleton.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewHouses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShowSecondForm;
        private System.Windows.Forms.NumericUpDown numericUpDownKey;
        private System.Windows.Forms.Label lblKey;

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
            dataGridViewHouses = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnShowSecondForm = new Button();
            numericUpDownKey = new NumericUpDown();
            lblKey = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHouses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKey).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHouses
            // 
            dataGridViewHouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHouses.Location = new Point(12, 15);
            dataGridViewHouses.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHouses.MultiSelect = false;
            dataGridViewHouses.Name = "dataGridViewHouses";
            dataGridViewHouses.ReadOnly = true;
            dataGridViewHouses.RowHeadersWidth = 51;
            dataGridViewHouses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHouses.Size = new Size(969, 372);
            dataGridViewHouses.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(304, 410);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 66);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить по ключу";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(494, 410);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 66);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить по ключу";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(653, 410);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 66);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редактировать по ключу";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShowSecondForm
            // 
            btnShowSecondForm.Location = new Point(821, 410);
            btnShowSecondForm.Margin = new Padding(3, 4, 3, 4);
            btnShowSecondForm.Name = "btnShowSecondForm";
            btnShowSecondForm.Size = new Size(160, 66);
            btnShowSecondForm.TabIndex = 6;
            btnShowSecondForm.Text = "Показать вторую форму";
            btnShowSecondForm.UseVisualStyleBackColor = true;
            btnShowSecondForm.Click += btnShowSecondForm_Click;
            // 
            // numericUpDownKey
            // 
            numericUpDownKey.Location = new Point(96, 431);
            numericUpDownKey.Margin = new Padding(3, 4, 3, 4);
            numericUpDownKey.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownKey.Name = "numericUpDownKey";
            numericUpDownKey.Size = new Size(100, 27);
            numericUpDownKey.TabIndex = 1;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(31, 433);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(46, 20);
            lblKey.TabIndex = 2;
            lblKey.Text = "Ключ";
            lblKey.Click += lblKey_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 505);
            Controls.Add(btnShowSecondForm);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblKey);
            Controls.Add(numericUpDownKey);
            Controls.Add(dataGridViewHouses);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Лабораторная работа №3 ";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHouses).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}