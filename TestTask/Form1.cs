using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] positions = new string[3] 
            {
                ".\\SQLEXPRESS", 
                "(localdb)\\MSSQLLocalDb", 
                "localhost" 
            };

            comboBoxConnection.Items.AddRange(positions);
            comboBoxConnection.Text = "Select";

            radioBtnExisting.Select();

            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnReport.Visible = false;
            checkedListBox1.Visible = false;
        }

        public void Filters()
        {
            var asd = checkedListBox1.CheckedItems;
            List<string> strArr = new List<string>();
            foreach (var itemChecked in asd)
            {
                string comapnyName = itemChecked.ToString();
                strArr.Add(comapnyName);
            }

            dataGridView1.Rows.Clear();

            var data = Db.GetTableData(strArr.ToArray());

            foreach (var s in data)
                dataGridView1.Rows.Add(s);
        }

        public void UpdateAfterDelition()
        {
            checkedListBox1.Items.Clear();

            var asd = Db.GetPositions();

            foreach (var s in asd)
            {
                checkedListBox1.Items.Add(s);
                checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, true);
            }

            dataGridView1.Rows.Clear();

            var data = Db.GetTableData(asd);

            foreach (var s in data)
                dataGridView1.Rows.Add(s);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                Db.DeleteRecord(Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
                UpdateAfterDelition();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string connection = String.Empty;

            if (radioBtnNew.Checked && textBoxConnection.Text != String.Empty)
                connection = textBoxConnection.Text;

            if (radioBtnExisting.Checked && comboBoxConnection.Text != "Select")
                connection = comboBoxConnection.Text;

            if (connection != String.Empty)
            {
                bool result = Db.ChangeConnectionString(connection);

                if (result)
                {
                    dataGridView1.Visible = true;
                    btnAdd.Visible = true;
                    btnReport.Visible = true;
                    checkedListBox1.Visible = true;

                    Db.CreateDbAndTable();
                    UpdateAfterDelition();
                }
            }
        }

        private void radioBtnExisting_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxConnection.Show();
            textBoxConnection.Hide();
        }

        private void textBoxConnection_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioBtnNew_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxConnection.Hide();
            textBoxConnection.Show();
        }

        private void comboBoxConnection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
