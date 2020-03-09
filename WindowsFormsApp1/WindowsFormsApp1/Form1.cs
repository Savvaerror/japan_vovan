using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=303-20; Initial Catalog=summa; Integrated Security=true;");
        // осуществляется подключение к базе данных
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
            }
            // происходит проверка логина и пароля
            else
                MessageBox.Show("Не правильный логин или пароль");
            //выводит окно при не успешной авторизаци
        }
    }
}
