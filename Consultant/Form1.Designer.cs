namespace Consultant
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_SecondName = new System.Windows.Forms.Label();
            this.label_Patronymic = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SecondName = new System.Windows.Forms.TextBox();
            this.textBox_Patronymic = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Passport = new System.Windows.Forms.Label();
            this.textBox_Passport = new System.Windows.Forms.TextBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_DeleteUser = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_ChangeUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 223);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Имя";
            // 
            // label_SecondName
            // 
            this.label_SecondName.AutoSize = true;
            this.label_SecondName.Location = new System.Drawing.Point(12, 263);
            this.label_SecondName.Name = "label_SecondName";
            this.label_SecondName.Size = new System.Drawing.Size(73, 20);
            this.label_SecondName.TabIndex = 2;
            this.label_SecondName.Text = "Фамилия";
            // 
            // label_Patronymic
            // 
            this.label_Patronymic.AutoSize = true;
            this.label_Patronymic.Location = new System.Drawing.Point(12, 308);
            this.label_Patronymic.Name = "label_Patronymic";
            this.label_Patronymic.Size = new System.Drawing.Size(72, 20);
            this.label_Patronymic.TabIndex = 3;
            this.label_Patronymic.Text = "Отчество";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(12, 351);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(69, 20);
            this.label_Phone.TabIndex = 4;
            this.label_Phone.Text = "Телефон";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(98, 220);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_SecondName
            // 
            this.textBox_SecondName.Location = new System.Drawing.Point(98, 260);
            this.textBox_SecondName.Name = "textBox_SecondName";
            this.textBox_SecondName.Size = new System.Drawing.Size(125, 27);
            this.textBox_SecondName.TabIndex = 6;
            // 
            // textBox_Patronymic
            // 
            this.textBox_Patronymic.Location = new System.Drawing.Point(98, 305);
            this.textBox_Patronymic.Name = "textBox_Patronymic";
            this.textBox_Patronymic.Size = new System.Drawing.Size(125, 27);
            this.textBox_Patronymic.TabIndex = 7;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(98, 348);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(125, 27);
            this.textBox_Phone.TabIndex = 8;
            // 
            // label_Passport
            // 
            this.label_Passport.AutoSize = true;
            this.label_Passport.Location = new System.Drawing.Point(12, 397);
            this.label_Passport.Name = "label_Passport";
            this.label_Passport.Size = new System.Drawing.Size(75, 20);
            this.label_Passport.TabIndex = 9;
            this.label_Passport.Text = "Пасспорт";
            // 
            // textBox_Passport
            // 
            this.textBox_Passport.Location = new System.Drawing.Point(98, 394);
            this.textBox_Passport.Name = "textBox_Passport";
            this.textBox_Passport.Size = new System.Drawing.Size(125, 27);
            this.textBox_Passport.TabIndex = 10;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(354, 219);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(195, 29);
            this.button_AddUser.TabIndex = 11;
            this.button_AddUser.Text = "Добавить пользователя";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(587, 409);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(201, 29);
            this.button_Refresh.TabIndex = 12;
            this.button_Refresh.Text = "Обновить таблицу";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_DeleteUser
            // 
            this.button_DeleteUser.Location = new System.Drawing.Point(354, 258);
            this.button_DeleteUser.Name = "button_DeleteUser";
            this.button_DeleteUser.Size = new System.Drawing.Size(195, 29);
            this.button_DeleteUser.TabIndex = 13;
            this.button_DeleteUser.Text = "Удалить пользователя";
            this.button_DeleteUser.UseVisualStyleBackColor = true;
            this.button_DeleteUser.Click += new System.EventHandler(this.button_DeleteUser_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(354, 409);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(195, 29);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Сохранить изменения";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_ChangeUser
            // 
            this.button_ChangeUser.Location = new System.Drawing.Point(354, 293);
            this.button_ChangeUser.Name = "button_ChangeUser";
            this.button_ChangeUser.Size = new System.Drawing.Size(196, 29);
            this.button_ChangeUser.TabIndex = 15;
            this.button_ChangeUser.Text = "Изменить пользователя";
            this.button_ChangeUser.UseVisualStyleBackColor = true;
            this.button_ChangeUser.Click += new System.EventHandler(this.button_ChangeUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ChangeUser);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_DeleteUser);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.textBox_Passport);
            this.Controls.Add(this.label_Passport);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Patronymic);
            this.Controls.Add(this.textBox_SecondName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Patronymic);
            this.Controls.Add(this.label_SecondName);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label_Name;
        private Label label_SecondName;
        private Label label_Patronymic;
        private Label label_Phone;
        private TextBox textBox_Name;
        private TextBox textBox_SecondName;
        private TextBox textBox_Patronymic;
        private TextBox textBox_Phone;
        private Label label_Passport;
        private TextBox textBox_Passport;
        private Button button_AddUser;
        private Button button_Refresh;
        private Button button_DeleteUser;
        private Button button_Update;
        private Button button_ChangeUser;
    }
}