namespace WinFormsApp_OOP_Lab3_Singleton.Forms
{
    partial class SecondForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewHouses;

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
            this.dataGridViewHouses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouses)).BeginInit();
            this.SuspendLayout();

            // dataGridViewHouses
            this.dataGridViewHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHouses.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHouses.Name = "dataGridViewHouses";
            this.dataGridViewHouses.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewHouses.TabIndex = 0;
            this.dataGridViewHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHouses.ReadOnly = true;

            // SecondForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewHouses);
            this.Name = "SecondForm";
            this.Text = "Вторая форма (та же коллекция)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouses)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}