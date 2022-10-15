namespace TestTask
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnExisting = new System.Windows.Forms.RadioButton();
            this.radioBtnNew = new System.Windows.Forms.RadioButton();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.mTextBoxSalary = new System.Windows.Forms.MaskedTextBox();
            this.mTextBoxYearOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelYearOfBirth = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnExisting);
            this.panel1.Controls.Add(this.radioBtnNew);
            this.panel1.Location = new System.Drawing.Point(80, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 51);
            this.panel1.TabIndex = 32;
            // 
            // radioBtnExisting
            // 
            this.radioBtnExisting.AutoSize = true;
            this.radioBtnExisting.Location = new System.Drawing.Point(0, 23);
            this.radioBtnExisting.Name = "radioBtnExisting";
            this.radioBtnExisting.Size = new System.Drawing.Size(125, 17);
            this.radioBtnExisting.TabIndex = 17;
            this.radioBtnExisting.TabStop = true;
            this.radioBtnExisting.Text = "Сhoose  from existing";
            this.radioBtnExisting.UseVisualStyleBackColor = true;
            this.radioBtnExisting.CheckedChanged += new System.EventHandler(this.radioBtnExisting_CheckedChanged);
            // 
            // radioBtnNew
            // 
            this.radioBtnNew.AutoSize = true;
            this.radioBtnNew.Location = new System.Drawing.Point(0, 0);
            this.radioBtnNew.Name = "radioBtnNew";
            this.radioBtnNew.Size = new System.Drawing.Size(106, 17);
            this.radioBtnNew.TabIndex = 16;
            this.radioBtnNew.TabStop = true;
            this.radioBtnNew.Text = "Add new position";
            this.radioBtnNew.UseVisualStyleBackColor = true;
            this.radioBtnNew.CheckedChanged += new System.EventHandler(this.radioBtnNew_CheckedChanged);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(33, 189);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(174, 21);
            this.comboBoxPosition.TabIndex = 31;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(64, 19);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(108, 13);
            this.labelHint.TabIndex = 30;
            this.labelHint.Text = "Warning! Fill all fields.";
            this.labelHint.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(163, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 23);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mTextBoxSalary
            // 
            this.mTextBoxSalary.Location = new System.Drawing.Point(33, 272);
            this.mTextBoxSalary.Mask = "00000000";
            this.mTextBoxSalary.Name = "mTextBoxSalary";
            this.mTextBoxSalary.Size = new System.Drawing.Size(55, 20);
            this.mTextBoxSalary.TabIndex = 28;
            this.mTextBoxSalary.ValidatingType = typeof(int);
            // 
            // mTextBoxYearOfBirth
            // 
            this.mTextBoxYearOfBirth.AccessibleDescription = "";
            this.mTextBoxYearOfBirth.Location = new System.Drawing.Point(33, 233);
            this.mTextBoxYearOfBirth.Mask = "0000";
            this.mTextBoxYearOfBirth.Name = "mTextBoxYearOfBirth";
            this.mTextBoxYearOfBirth.Size = new System.Drawing.Size(33, 20);
            this.mTextBoxYearOfBirth.TabIndex = 27;
            this.mTextBoxYearOfBirth.ValidatingType = typeof(int);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add new employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(30, 256);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(36, 13);
            this.labelSalary.TabIndex = 25;
            this.labelSalary.Text = "Salary";
            // 
            // labelYearOfBirth
            // 
            this.labelYearOfBirth.AutoSize = true;
            this.labelYearOfBirth.Location = new System.Drawing.Point(30, 217);
            this.labelYearOfBirth.Name = "labelYearOfBirth";
            this.labelYearOfBirth.Size = new System.Drawing.Size(65, 13);
            this.labelYearOfBirth.TabIndex = 24;
            this.labelYearOfBirth.Text = "Year of Birth";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(30, 129);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 23;
            this.labelPosition.Text = "Position";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(30, 90);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 22;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(33, 190);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(174, 20);
            this.textBoxPosition.TabIndex = 20;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(33, 106);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(174, 20);
            this.textBoxSurname.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(33, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mTextBoxSalary);
            this.Controls.Add(this.mTextBoxYearOfBirth);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelYearOfBirth);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnExisting;
        private System.Windows.Forms.RadioButton radioBtnNew;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox mTextBoxSalary;
        private System.Windows.Forms.MaskedTextBox mTextBoxYearOfBirth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelYearOfBirth;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
    }
}