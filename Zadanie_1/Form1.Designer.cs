namespace Zadanie_3
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
            this.label__surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_post = new System.Windows.Forms.Label();
            this.label_House = new System.Windows.Forms.Label();
            this.label__street = new System.Windows.Forms.Label();
            this.textBox_House = new System.Windows.Forms.TextBox();
            this.comboBox_post = new System.Windows.Forms.ComboBox();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.comboBox_street = new System.Windows.Forms.ComboBox();
            this.button_add_post = new System.Windows.Forms.Button();
            this.button_add_city = new System.Windows.Forms.Button();
            this.button_add_street = new System.Windows.Forms.Button();
            this.listBox_worker = new System.Windows.Forms.ListBox();
            this.button_add_worker = new System.Windows.Forms.Button();
            this.label_list_worker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label__surname
            // 
            this.label__surname.Location = new System.Drawing.Point(6, 10);
            this.label__surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label__surname.Name = "label__surname";
            this.label__surname.Size = new System.Drawing.Size(101, 25);
            this.label__surname.TabIndex = 0;
            this.label__surname.Text = "Фамилия";
            this.label__surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.Location = new System.Drawing.Point(122, 10);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(147, 28);
            this.textBox_surname.TabIndex = 1;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_salary.Location = new System.Drawing.Point(122, 44);
            this.textBox_salary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(147, 28);
            this.textBox_salary.TabIndex = 3;
            // 
            // label_salary
            // 
            this.label_salary.Location = new System.Drawing.Point(6, 44);
            this.label_salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(101, 25);
            this.label_salary.TabIndex = 2;
            this.label_salary.Text = "Зарплата";
            this.label_salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_city
            // 
            this.label_city.Location = new System.Drawing.Point(6, 114);
            this.label_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(101, 25);
            this.label_city.TabIndex = 5;
            this.label_city.Text = "Город";
            this.label_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_post
            // 
            this.label_post.Location = new System.Drawing.Point(6, 81);
            this.label_post.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_post.Name = "label_post";
            this.label_post.Size = new System.Drawing.Size(101, 25);
            this.label_post.TabIndex = 4;
            this.label_post.Text = "Должность";
            this.label_post.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_House
            // 
            this.label_House.Location = new System.Drawing.Point(6, 182);
            this.label_House.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_House.Name = "label_House";
            this.label_House.Size = new System.Drawing.Size(101, 25);
            this.label_House.TabIndex = 7;
            this.label_House.Text = "Дом";
            this.label_House.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label__street
            // 
            this.label__street.Location = new System.Drawing.Point(6, 148);
            this.label__street.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label__street.Name = "label__street";
            this.label__street.Size = new System.Drawing.Size(101, 25);
            this.label__street.TabIndex = 6;
            this.label__street.Text = "Улица";
            this.label__street.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_House
            // 
            this.textBox_House.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_House.Location = new System.Drawing.Point(122, 182);
            this.textBox_House.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_House.Name = "textBox_House";
            this.textBox_House.Size = new System.Drawing.Size(147, 28);
            this.textBox_House.TabIndex = 8;
            // 
            // comboBox_post
            // 
            this.comboBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_post.FormattingEnabled = true;
            this.comboBox_post.Location = new System.Drawing.Point(122, 77);
            this.comboBox_post.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_post.Name = "comboBox_post";
            this.comboBox_post.Size = new System.Drawing.Size(147, 30);
            this.comboBox_post.TabIndex = 9;
            // 
            // comboBox_city
            // 
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(122, 114);
            this.comboBox_city.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(147, 30);
            this.comboBox_city.TabIndex = 10;
            // 
            // comboBox_street
            // 
            this.comboBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_street.FormattingEnabled = true;
            this.comboBox_street.Location = new System.Drawing.Point(122, 148);
            this.comboBox_street.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_street.Name = "comboBox_street";
            this.comboBox_street.Size = new System.Drawing.Size(147, 30);
            this.comboBox_street.TabIndex = 11;
            // 
            // button_add_post
            // 
            this.button_add_post.Location = new System.Drawing.Point(288, 77);
            this.button_add_post.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add_post.Name = "button_add_post";
            this.button_add_post.Size = new System.Drawing.Size(92, 26);
            this.button_add_post.TabIndex = 12;
            this.button_add_post.Text = "Добавить";
            this.button_add_post.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_add_post.UseVisualStyleBackColor = true;
            this.button_add_post.Click += new System.EventHandler(this.Button_add_post_Click);
            // 
            // button_add_city
            // 
            this.button_add_city.Location = new System.Drawing.Point(288, 114);
            this.button_add_city.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add_city.Name = "button_add_city";
            this.button_add_city.Size = new System.Drawing.Size(92, 25);
            this.button_add_city.TabIndex = 13;
            this.button_add_city.Text = "Добавить";
            this.button_add_city.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_add_city.UseVisualStyleBackColor = true;
            this.button_add_city.Click += new System.EventHandler(this.Button_add_city_Click);
            // 
            // button_add_street
            // 
            this.button_add_street.Location = new System.Drawing.Point(288, 148);
            this.button_add_street.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add_street.Name = "button_add_street";
            this.button_add_street.Size = new System.Drawing.Size(92, 26);
            this.button_add_street.TabIndex = 14;
            this.button_add_street.Text = "Добавить";
            this.button_add_street.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_add_street.UseVisualStyleBackColor = true;
            this.button_add_street.Click += new System.EventHandler(this.Button_add_street_Click);
            // 
            // listBox_worker
            // 
            this.listBox_worker.FormattingEnabled = true;
            this.listBox_worker.Location = new System.Drawing.Point(398, 49);
            this.listBox_worker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_worker.Name = "listBox_worker";
            this.listBox_worker.Size = new System.Drawing.Size(218, 225);
            this.listBox_worker.TabIndex = 15;
            // 
            // button_add_worker
            // 
            this.button_add_worker.Location = new System.Drawing.Point(8, 231);
            this.button_add_worker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add_worker.Name = "button_add_worker";
            this.button_add_worker.Size = new System.Drawing.Size(259, 35);
            this.button_add_worker.TabIndex = 16;
            this.button_add_worker.Text = "Добавить";
            this.button_add_worker.UseVisualStyleBackColor = true;
            this.button_add_worker.Click += new System.EventHandler(this.Button_add_worker_Click);
            // 
            // label_list_worker
            // 
            this.label_list_worker.Location = new System.Drawing.Point(398, 10);
            this.label_list_worker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_list_worker.Name = "label_list_worker";
            this.label_list_worker.Size = new System.Drawing.Size(218, 25);
            this.label_list_worker.TabIndex = 17;
            this.label_list_worker.Text = "Список работников";
            this.label_list_worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 287);
            this.Controls.Add(this.label_list_worker);
            this.Controls.Add(this.button_add_worker);
            this.Controls.Add(this.listBox_worker);
            this.Controls.Add(this.button_add_street);
            this.Controls.Add(this.button_add_city);
            this.Controls.Add(this.button_add_post);
            this.Controls.Add(this.comboBox_street);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.comboBox_post);
            this.Controls.Add(this.textBox_House);
            this.Controls.Add(this.label_House);
            this.Controls.Add(this.label__street);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_post);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label__surname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label__surname;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_post;
        private System.Windows.Forms.Label label_House;
        private System.Windows.Forms.Label label__street;
        private System.Windows.Forms.TextBox textBox_House;
        private System.Windows.Forms.ComboBox comboBox_post;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.ComboBox comboBox_street;
        private System.Windows.Forms.Button button_add_post;
        private System.Windows.Forms.Button button_add_city;
        private System.Windows.Forms.Button button_add_street;
        private System.Windows.Forms.ListBox listBox_worker;
        private System.Windows.Forms.Button button_add_worker;
        private System.Windows.Forms.Label label_list_worker;
    }
}

