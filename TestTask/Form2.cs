using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestTask
{
    public partial class Form2 : Form
    {
        private readonly Form1 mainForm;
        public Form2(Form1 form)
        {
            mainForm = form;

            InitializeComponent();

            string[] positions = Db.GetPositions();

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(positions);
            textBoxPosition.AutoCompleteCustomSource = source;
            textBoxPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxPosition.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBoxPosition.Items.AddRange(positions);
            comboBoxPosition.Text = "Select";

            radioBtnNew.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text != String.Empty
                && textBoxSurname.Text != String.Empty
                && mTextBoxSalary.Text != String.Empty
                && mTextBoxYearOfBirth.Text != String.Empty)
            {
                string position = String.Empty;

                if (radioBtnNew.Checked && textBoxPosition.Text != String.Empty)
                    position = textBoxPosition.Text;

                if (radioBtnExisting.Checked && comboBoxPosition.Text != "Select")
                    position = comboBoxPosition.Text;

                if (position != String.Empty)
                {
                    Db.AddRecord(textBoxName.Text,
                                textBoxSurname.Text,
                                position,
                                Convert.ToInt32(mTextBoxSalary.Text),
                                Convert.ToInt32(mTextBoxYearOfBirth.Text));

                    mainForm.UpdateAfterDelition();
                    this.Close();
                }
            }
            labelHint.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnNew_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPosition.Hide();
            textBoxPosition.Show();
        }

        private void radioBtnExisting_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPosition.Hide();
            comboBoxPosition.Show();
        }
    }
}
