namespace ProyekResponsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_Karyawan = new TextBox();
            comboBox_Dep = new ComboBox();
            btn_Insert = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 89);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 146);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan";
            // 
            // txt_Karyawan
            // 
            txt_Karyawan.Location = new Point(177, 86);
            txt_Karyawan.Name = "txt_Karyawan";
            txt_Karyawan.Size = new Size(178, 23);
            txt_Karyawan.TabIndex = 2;
            // 
            // comboBox_Dep
            // 
            comboBox_Dep.FormattingEnabled = true;
            comboBox_Dep.Location = new Point(177, 143);
            comboBox_Dep.Name = "comboBox_Dep";
            comboBox_Dep.Size = new Size(178, 23);
            comboBox_Dep.TabIndex = 3;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(149, 198);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 4;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(318, 198);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 23);
            btn_Edit.TabIndex = 5;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(494, 198);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 6;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 64);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "ID Departemen:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 86);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "HR: HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(543, 101);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 9;
            label5.Text = "ENG : Engineer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 116);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 10;
            label6.Text = "DEV : Developer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 131);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 11;
            label7.Text = "PM : Product Manager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(543, 146);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 12;
            label8.Text = "FIN : Finance";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(78, 227);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(648, 211);
            dgvData.TabIndex = 13;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Insert);
            Controls.Add(comboBox_Dep);
            Controls.Add(txt_Karyawan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Karyawan;
        private ComboBox comboBox_Dep;
        private Button btn_Insert;
        private Button btn_Edit;
        private Button btn_Delete;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvData;
    }
}
