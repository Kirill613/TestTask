namespace TestTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelTextPos = new System.Windows.Forms.Label();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.radioBtnNew = new System.Windows.Forms.RadioButton();
            this.radioBtnExisting = new System.Windows.Forms.RadioButton();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.comboBoxConnection = new System.Windows.Forms.ComboBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 42);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 139);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(701, 111);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(701, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.position,
            this.year_of_birth,
            this.salary,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 209);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // position
            // 
            this.position.HeaderText = "position";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // year_of_birth
            // 
            this.year_of_birth.HeaderText = "year_of_birth";
            this.year_of_birth.Name = "year_of_birth";
            this.year_of_birth.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.HeaderText = "salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "Delete";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "Delete";
            this.delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            // 
            // labelTextPos
            // 
            this.labelTextPos.AutoSize = true;
            this.labelTextPos.Location = new System.Drawing.Point(12, 17);
            this.labelTextPos.Name = "labelTextPos";
            this.labelTextPos.Size = new System.Drawing.Size(88, 13);
            this.labelTextPos.TabIndex = 11;
            this.labelTextPos.Text = "Existing Positions";
            // 
            // panelConnection
            // 
            this.panelConnection.Controls.Add(this.btnConnection);
            this.panelConnection.Controls.Add(this.labelConnection);
            this.panelConnection.Controls.Add(this.comboBoxConnection);
            this.panelConnection.Controls.Add(this.textBoxConnection);
            this.panelConnection.Controls.Add(this.radioBtnExisting);
            this.panelConnection.Controls.Add(this.radioBtnNew);
            this.panelConnection.Location = new System.Drawing.Point(499, 44);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(187, 141);
            this.panelConnection.TabIndex = 12;
            // 
            // radioBtnNew
            // 
            this.radioBtnNew.AutoSize = true;
            this.radioBtnNew.Location = new System.Drawing.Point(3, 35);
            this.radioBtnNew.Name = "radioBtnNew";
            this.radioBtnNew.Size = new System.Drawing.Size(115, 17);
            this.radioBtnNew.TabIndex = 0;
            this.radioBtnNew.TabStop = true;
            this.radioBtnNew.Text = "Enter Server Name";
            this.radioBtnNew.UseVisualStyleBackColor = true;
            this.radioBtnNew.CheckedChanged += new System.EventHandler(this.radioBtnNew_CheckedChanged);
            // 
            // radioBtnExisting
            // 
            this.radioBtnExisting.AutoSize = true;
            this.radioBtnExisting.Location = new System.Drawing.Point(3, 58);
            this.radioBtnExisting.Name = "radioBtnExisting";
            this.radioBtnExisting.Size = new System.Drawing.Size(96, 17);
            this.radioBtnExisting.TabIndex = 1;
            this.radioBtnExisting.TabStop = true;
            this.radioBtnExisting.Text = "Choose default";
            this.radioBtnExisting.UseVisualStyleBackColor = true;
            this.radioBtnExisting.CheckedChanged += new System.EventHandler(this.radioBtnExisting_CheckedChanged);
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Location = new System.Drawing.Point(3, 82);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(163, 20);
            this.textBoxConnection.TabIndex = 2;
            this.textBoxConnection.TextChanged += new System.EventHandler(this.textBoxConnection_TextChanged);
            // 
            // comboBoxConnection
            // 
            this.comboBoxConnection.FormattingEnabled = true;
            this.comboBoxConnection.Location = new System.Drawing.Point(3, 82);
            this.comboBoxConnection.Name = "comboBoxConnection";
            this.comboBoxConnection.Size = new System.Drawing.Size(163, 21);
            this.comboBoxConnection.TabIndex = 3;
            this.comboBoxConnection.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnection_SelectedIndexChanged);
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(3, 17);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(134, 13);
            this.labelConnection.TabIndex = 4;
            this.labelConnection.Text = "Choose Connection Server";
            this.labelConnection.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(3, 109);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(163, 23);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "Confirm Settings";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 415);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.labelTextPos);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label labelTextPos;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.RadioButton radioBtnExisting;
        private System.Windows.Forms.RadioButton radioBtnNew;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.ComboBox comboBoxConnection;
        private System.Windows.Forms.Button btnConnection;
    }
}

