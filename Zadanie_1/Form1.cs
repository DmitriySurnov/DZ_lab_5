using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Zadanie_3{
    public partial class Form1 : Form{
        string pyth = "worker.txt";
        public Form1(){
            InitializeComponent();
            if (File.Exists(pyth)){
                string[] file = File.ReadAllLines(pyth);
                for(int i = 0; i < file.Length; i++)
                    if (!String.IsNullOrWhiteSpace(file[i]))
                    {
                        listBox_worker.Items.Add(file[i]);
                        string[] stroka = file[i].Split(',');
                        if (!comboBox_post.Items.Contains(stroka[2]))
                            comboBox_post.Items.Add(stroka[2]);
                        if (!comboBox_city.Items.Contains(stroka[3]))
                            comboBox_city.Items.Add(stroka[3]);
                        if (!comboBox_street.Items.Contains(stroka[4]))
                            comboBox_street.Items.Add(stroka[4]);
                    }    
            }
        }

        private void Add_comboBox(ComboBox b)
        {
            if (b.Text != "" && !b.Items.Contains(b.Text))
                b.Items.Add(b.Text);
        }

        private void Button_add_post_Click(object sender, EventArgs e)
        {
            Add_comboBox(comboBox_post);
        }

        private void Button_add_city_Click(object sender, EventArgs e)
        {
            Add_comboBox(comboBox_city);
        }

        private void Button_add_street_Click(object sender, EventArgs e)
        {
            Add_comboBox(comboBox_street);
        }

        private void Button_add_worker_Click(object sender, EventArgs e)
        {
            foreach (var b in Controls.OfType<ComboBox>())
                Add_comboBox(b);
            if (textBox_surname.Text == "")
                ErrorBox("Фамилия");
            else if (!IsNamber(textBox_salary))
                ErrorBox("Зарплата");
            else if (comboBox_post.Text == "")
                ErrorBox("Должность");
            else if (comboBox_city.Text == "")
                ErrorBox("Город");
            else if (comboBox_street.Text == "")
                ErrorBox("Улица");
            else if (!IsNamber(textBox_House))
                ErrorBox("№ дома");
            else{
                var file = new StreamWriter(pyth, true);
                string stroka = textBox_surname.Text + "," +
                    textBox_salary.Text + "," + comboBox_post.Text + "," +
                    comboBox_city.Text + "," + comboBox_street.Text + ","
                    + textBox_House.Text;
                file.WriteLine(stroka);
                file.Close();
                listBox_worker.Items.Add(stroka);
                foreach (var b in Controls.OfType<ComboBox>())
                    b.Text = "";
                foreach (var b in Controls.OfType<TextBox>())
                    b.Text = "";
            }
        }
        private bool IsNamber(TextBox t)
        {
            try{
                uint namber = Convert.ToUInt32(t.Text);
                if (namber == 0)
                    return false;
                return true;
            }
            catch (Exception){
                return false;
            }
        }
        private void ErrorBox(string namePolia){
            MessageBox.Show(
                   "Вы не заполнили поле или заполнено нероректно'" + namePolia + "'",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
    }
}
