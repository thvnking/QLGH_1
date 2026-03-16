using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private DataConnection db = new DataConnection();
        private string currentTable = "";
        private string currentQuery = "";
        private DateTimePicker datePicker = new DateTimePicker();
        private bool isAddingNew = false;

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView1();
            SetupDatePicker();

            // Ẩn GridView2 nếu nó vẫn còn tồn tại trong Designer
            if (dataGridView2 != null) dataGridView2.Visible = false;
        }

        private void SetupDataGridView1()
        {
            dataGridView1.DataError += (s, e) => { e.ThrowException = false; };
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Đăng ký sự kiện để bắt đầu chỉnh sửa
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            // Tùy chỉnh thiết kế
            ApplyCustomDesign(dataGridView1);
        }

        public void LoadData(string query)
        {
            currentQuery = query;
            var match = Regex.Match(query, @"FROM\s+\[?(\w+)\]?", RegexOptions.IgnoreCase);
            if (match.Success) currentTable = match.Groups[1].Value;

            DataTable dt = db.GetDataTable(query);

            // Tạm dừng sự kiện CellValueChanged để không trigger khi load data
            dataGridView1.CellValueChanged -= DataGridView1_CellValueChanged;
            dataGridView1.DataSource = dt;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            SetupStatusComboBox(dataGridView1);
            AddActionButtons();
            lblList.Text = currentTable;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || isAddingNew) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string pk = GetPrimaryKeyName();
            string pkValue = row.Cells[pk].Value.ToString();

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            object newValue = row.Cells[e.ColumnIndex].Value;
            string formattedValue = FormatSqlValue(colName, newValue);
            string sql = $"UPDATE [{currentTable}] SET [{colName}] = {formattedValue} WHERE [{pk}] = {pkValue}";

            if (db.ExecuteNonQuery(sql))
            {
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            string pk = GetPrimaryKeyName();

            if (colName == "btnDelete")
            {
                if (MessageBox.Show("Xác nhận xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string idValue = dataGridView1.Rows[e.RowIndex].Cells[pk].Value.ToString();
                    if (db.ExecuteNonQuery($"DELETE FROM [{currentTable}] WHERE [{pk}] = {idValue}"))
                        LoadData(currentQuery);
                }
            }
            if (colName.ToLower().Contains("ngay"))
            {
                Rectangle rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                datePicker.Size = new Size(rect.Width, rect.Height);
                datePicker.Location = new Point(rect.X, rect.Y);
                datePicker.Visible = true;
            }
            else datePicker.Visible = false;
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable)) return;
            string pk = GetPrimaryKeyName();
            string newId = GenerateAutoID(pk);
            string sql = $"INSERT INTO [{currentTable}] ([{pk}]) VALUES ({newId})";
            if (db.ExecuteNonQuery(sql))
            {
                LoadData(currentQuery);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
            }
        }

        private string FormatSqlValue(string colName, object val)
        {
            if (val == null || val == DBNull.Value) return "NULL";
            string sVal = val.ToString();

            if (colName == "MaKH") sVal = ResolveMaKH(sVal);

            if (colName.ToLower().Contains("ngay") && DateTime.TryParse(sVal, out DateTime dt))
                return $"'{dt:yyyy-MM-dd}'";

            if (decimal.TryParse(sVal, out decimal num))
                return num.ToString();

            return $"N'{sVal.Replace("'", "''")}'";
        }

        private string GetPrimaryKeyName()
        {
            return dataGridView1.Columns.Cast<DataGridViewColumn>()
                .First(c => !(c is DataGridViewButtonColumn)).Name;
        }

        private void SetupStatusComboBox(DataGridView dgv)
        {
            if (dgv.Columns.Cast<DataGridViewColumn>().Any(c => c is DataGridViewComboBoxColumn)) return;

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Name.ToLower().Contains("trangthai"))
                {
                    string colName = dgv.Columns[i].Name;
                    int colIdx = dgv.Columns[i].Index;

                    DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn
                    {
                        Name = colName,
                        HeaderText = "Trạng thái",
                        DataPropertyName = colName,
                        FlatStyle = FlatStyle.Flat
                    };
                    combo.Items.AddRange("Đang xử lý", "Đang giao", "Hoàn thành", "Đã hủy");

                    dgv.Columns.RemoveAt(colIdx);
                    dgv.Columns.Insert(colIdx, combo);
                }
            }
        }

        private void AddActionButtons()
        {
            if (!dataGridView1.Columns.Contains("btnDelete"))
            {
                var deleteBtn = new DataGridViewButtonColumn
                {
                    Name = "btnDelete",
                    HeaderText = "Xóa",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat
                };
                deleteBtn.DefaultCellStyle.ForeColor = Color.Red;
                dataGridView1.Columns.Add(deleteBtn);
            }
        }

        private void SetupDatePicker()
        {
            datePicker.Visible = false;
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.ValueChanged += (s, e) => {
                if (dataGridView1.CurrentCell != null)
                    dataGridView1.CurrentCell.Value = datePicker.Value.ToString("yyyy-MM-dd");
            };
            dataGridView1.Controls.Add(datePicker);
        }
        private string ResolveMaKH(string input) { return input; }
        private string GenerateAutoID(string pkColumn) { return "1"; }
        private void ApplyCustomDesign(DataGridView dgv) { }
    }
}