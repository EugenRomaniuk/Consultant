namespace Consultant
{
    partial class Form_AddUser
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_SecondName = new System.Windows.Forms.Label();
            this.label_Patronymic = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Passport = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SecondName = new System.Windows.Forms.TextBox();
            this.textBox_Patronymic = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Passport = new System.Windows.Forms.TextBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 20);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Имя";
            // 
            // label_SecondName
            // 
            this.label_SecondName.AutoSize = true;
            this.label_SecondName.Location = new System.Drawing.Point(12, 48);
            this.label_SecondName.Name = "label_SecondName";
            this.label_SecondName.Size = new System.Drawing.Size(73, 20);
            this.label_SecondName.TabIndex = 1;
            this.label_SecondName.Text = "Фамилия";
            // 
            // label_Patronymic
            // 
            this.label_Patronymic.AutoSize = true;
            this.label_Patronymic.Location = new System.Drawing.Point(12, 90);
            this.label_Patronymic.Name = "label_Patronymic";
            this.label_Patronymic.Size = new System.Drawing.Size(72, 20);
            this.label_Patronymic.TabIndex = 2;
            this.label_Patronymic.Text = "Отчество";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(12, 134);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(69, 20);
            this.label_Phone.TabIndex = 3;
            this.label_Phone.Text = "Телефон";
            // 
            // label_Passport
            // 
            this.label_Passport.AutoSize = true;
            this.label_Passport.Location = new System.Drawing.Point(12, 176);
            this.label_Passport.Name = "label_Passport";
            this.label_Passport.Size = new System.Drawing.Size(75, 20);
            this.label_Passport.TabIndex = 4;
            this.label_Passport.Text = "Пасспорт";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(114, 6);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_SecondName
            // 
            this.textBox_SecondName.Location = new System.Drawing.Point(114, 45);
            this.textBox_SecondName.Name = "textBox_SecondName";
            this.textBox_SecondName.Size = new System.Drawing.Size(125, 27);
            this.textBox_SecondName.TabIndex = 6;
            // 
            // textBox_Patronymic
            // 
            this.textBox_Patronymic.Location = new System.Drawing.Point(114, 87);
            this.textBox_Patronymic.Name = "textBox_Patronymic";
            this.textBox_Patronymic.Size = new System.Drawing.Size(125, 27);
            this.textBox_Patronymic.TabIndex = 7;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(114, 131);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(125, 27);
            this.textBox_Phone.TabIndex = 8;
            // 
            // textBox_Passport
            // 
            this.textBox_Passport.Location = new System.Drawing.Point(114, 173);
            this.textBox_Passport.Name = "textBox_Passport";
            this.textBox_Passport.Size = new System.Drawing.Size(125, 27);
            this.textBox_Passport.TabIndex = 9;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(288, 72);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(94, 29);
            this.button_AddUser.TabIndex = 10;
            this.button_AddUser.Text = "Добавить";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.textBox_Passport);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Patronymic);
            this.Controls.Add(this.textBox_SecondName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Passport);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Patronymic);
            this.Controls.Add(this.label_SecondName);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_AddUser";
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Name;
        private Label label_SecondName;
        private Label label_Patronymic;
        private Label label_Phone;
        private Label label_Passport;
        private TextBox textBox_Name;
        private TextBox textBox_SecondName;
        private TextBox textBox_Patronymic;
        private TextBox textBox_Phone;
        private TextBox textBox_Passport;
        private Button button_AddUser;
    }
}